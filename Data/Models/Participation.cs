using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Data.Models
{
    public class Participation
    {
        public int Id { get; set; }

        [Required]
        public int CircuitSeasonId { get; set; }

        public CircuitSeason CircuitSeason { get; set; }

        [Required]
        public int DriverSeasonId { get; set; }

        public DriverSeason DriverSeason { get; set; }

        [Required]
        public int TeamId { get; set; }

        public Team Team { get; set; }
    }
}