using System;
using System.ComponentModel.DataAnnotations;

namespace F1_App.Data.Models
{
    public class UpcomingRace
    {
        [Key]
        public int Id { get; set; }

        public string RaceName { get; set; }
        public DateTime Date { get; set; }
        public Track Track { get; set; }
    }
}
