using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class ParticipationListViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Circuit Season")]
        public int CircuitSeasonId { get; set; }

        public string CircuitName { get; set; } = string.Empty;

        public DateTime? RaceDate { get; set; }

        [Required]
        [Display(Name = "Driver")]
        public int DriverSeasonId { get; set; }

        public string DriverName { get; set; } = string.Empty;

        public int DriverNumber { get; set; }

        [Required]
        [Display(Name = "Team")]
        public int TeamId { get; set; }

        public string TeamName { get; set; } = string.Empty;

        public string TeamCountry { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}
