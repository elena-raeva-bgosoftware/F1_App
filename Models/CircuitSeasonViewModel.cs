using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class CircuitSeasonViewModel
    {
        public int Id { get; set; }

        public string CircuitName { get; set; } = string.Empty;

        public DateTime? RaceDate { get; set; }

        public string ImageUrl { get; set; } = string.Empty;
    }
}
