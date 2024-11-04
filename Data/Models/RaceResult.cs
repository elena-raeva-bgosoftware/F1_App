using System;
using System.ComponentModel.DataAnnotations;

namespace F1_App.Data.Models
{
    public class RaceResult
    {
        [Key]
        public int Id { get; set; }

        public int RaceId { get; set; }
        public Driver Driver { get; set; }
        public int Position { get; set; }
        public string RaceName { get; set; }
        public DateTime RaceDate { get; set; }
    }
}
