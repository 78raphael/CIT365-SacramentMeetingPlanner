using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Data;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Controllers
{
    public class MeetingsController : Controller
    {
        private readonly SacramentMeetingContext _context;

        public MeetingsController(SacramentMeetingContext context)
        {
            _context = context;
        }

        // GET: Meetings
        public async Task<IActionResult> Index(int? id)
        {
            var viewModel = new MeetingIndexModel();
            viewModel.Meetings = await _context.Meetings
                .Include(m => m.Speakers)
                .AsNoTracking()
                .OrderByDescending(m => m.MeetingDate)
                .ToListAsync();

            if (id != null)
            {
                ViewData["MeetingId"] = id.Value;
                Meeting meeting = viewModel.Meetings.Where(m => m.ID == id.Value).Single();
            }
              return View(viewModel);
        }

        // GET: Meetings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Meetings == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .Include(s => s.Speakers)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // GET: Meetings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MeetingDate,Conducting,OpeningSongHymn,OpeningSong, SacramentHymnChoice,SacramentHymn,ClosingSong,ClosingSongHymn,IntermediateMusicalNumber, IntermediateMusicalNumberHymn,Invocation,Benediction")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meeting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Meetings == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings.FindAsync(id);
            if (meeting == null)
            {
                return NotFound();
            }
            return View(meeting);
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MeetingDate,Conducting,OpeningSongHymn,OpeningSong, SacramentHymnChoice,SacramentHymn,ClosingSong,ClosingSongHymn,IntermediateMusicalNumber, IntermediateMusicalNumberHymn,Invocation,Benediction")] Meeting meeting)
        {
            if (id != meeting.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meeting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingExists(meeting.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(meeting);
        }

        // GET: Meetings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Meetings == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meetings
                .FirstOrDefaultAsync(m => m.ID == id);
            if (meeting == null)
            {
                return NotFound();
            }

            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Meetings == null)
            {
                return Problem("Entity set 'SacramentMeetingContext.Meetings'  is null.");
            }
            var meeting = await _context.Meetings.FindAsync(id);
            if (meeting != null)
            {
                _context.Meetings.Remove(meeting);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingExists(int id)
        {
          return _context.Meetings.Any(e => e.ID == id);
        }
    }
}
