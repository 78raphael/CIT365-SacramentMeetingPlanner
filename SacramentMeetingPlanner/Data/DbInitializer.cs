using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SacramentMeetingPlanner.Models;
using SacramentMeetingPlanner.Enums;
using SacramentMeetingPlanner.Migrations;

namespace SacramentMeetingPlanner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SacramentMeetingContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            if (context.Meetings.Any())
            {
                return;   // DB has been seeded
            }

            var meetings = new Meeting[]
            {

                new Meeting { Conducting = "Bishop Ted Marcus",   OpeningSong = "#2 The Spirit of God ", SacramentHymn = "#178 O Lord Of Hosts ", ClosingSong = "#3 Now Let Us Rejoice ", IntermediateMusicalNumber = "#89 The Lord Is My Light ", Invocation = "Kayla Jean", Benediction = " Lily Jones",
                    MeetingDate = DateTime.Parse("2010-09-01") },
                new Meeting { Conducting = "Brother Ron Wilson", OpeningSong = "#6 Redeemer of Israel", SacramentHymn = "#181 Jesus Of Nazareth, Savior and King ", ClosingSong = "#77 Great Is The Lord ", Invocation = "Tyler Hanson", Benediction = "Hailey Madison",
                    MeetingDate = DateTime.Parse("2012-09-01") },
                new Meeting { Conducting = "Brother Mike Hall",   OpeningSong = "#21 Come, Listen to a Prophet's Voice", SacramentHymn = "#183 In Remembrance of Thy Suffering ", ClosingSong = "#85 How Firm A Foundation ", IntermediateMusicalNumber = "#92 For The Beauty Of The Earth ", Invocation = "Sally King", Benediction = "John Camron",

                    MeetingDate = DateTime.Parse("2013-09-01") }

            };

            foreach (Meeting m in meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();

            var speakers = new Speaker[]
            {
                new Speaker { FirstName = "Kim",     LastName = "Gaden", Subject = "Jesus Christ", MeetingId =1},
                new Speaker { FirstName = "Fadi",    LastName = "Fakhouri", Subject = "Atonement", MeetingId =1},
                new Speaker { FirstName = "Roger",   LastName = "Harui", Subject = "Prophets", MeetingId = 2},
                new Speaker { FirstName = "Candace", LastName = "Kapoor", Subject = "Temples", MeetingId = 2},
                new Speaker { FirstName = "Roger",   LastName = "Moore", Subject = "Priesthood", MeetingId = 3},
                new Speaker { FirstName = "Lara",   LastName = "Hahn", Subject = "Holy Ghost", MeetingId = 3}
            };

            foreach (Speaker s in speakers)
            {
                context.Speakers.Add(s);
            }
            context.SaveChanges();

        }
    }
}