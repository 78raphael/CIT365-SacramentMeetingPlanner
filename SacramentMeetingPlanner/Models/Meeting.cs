using SacramentMeetingPlanner.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [RegularExpression(@"[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Conducting { get; set; }

        public string OpeningSong { get; set; }

        public HymnsEnum OpeningSongHymn { get; set; }
        public string SacramentHymn { get; set; }
        public HymnsEnum SacramentHymnChoice { get; set; }

        public string ClosingSong { get; set; }

        public HymnsEnum ClosingSongHymn { get; set; }

        #nullable enable
        public string? IntermediateMusicalNumber { get; set; }

        public HymnsEnum? IntermediateMusicalNumberHymn { get; set; }
        #nullable disable

        [RegularExpression(@"[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Invocation { get; set; }

        [RegularExpression(@"[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Benediction { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
    }
}
