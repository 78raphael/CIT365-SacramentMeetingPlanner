using System.Collections;
using System.Collections.Generic;

namespace SacramentMeetingPlanner.Models
{
    public class MeetingIndexModel
    {
        public IEnumerable<Meeting> Meetings { get; set; }
        public IEnumerable<Speaker> Speaker { get; set; }
    }
}
