using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Data.Models
{
    public class CircuitSeason
    {
        public int Id { get; set; }

        [Required]
        public int CircuitId { get; set; }

        public Circuit Circuit { get; set; }

        public DateTime? Date { get; set; }

        public ICollection<Result> Results { get; set; } = new List<Result>();
    }
}