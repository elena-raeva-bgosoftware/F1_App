using F1_Web_App.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }

        [Required]
        public string CircuitName { get; set; } = null!;

        [Required]
        public string Country { get; set; } = null!;

        [Required]
        public DateTime EventDate { get; set; }

        public string ImageUrl { get; set; } = null!;
    }
}