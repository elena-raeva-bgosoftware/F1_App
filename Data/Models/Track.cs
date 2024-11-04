using System.ComponentModel.DataAnnotations;

namespace F1_App.Data.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public double LengthKm { get; set; }

        [Url]
        public string PhotoUrl { get; set; }
    }
}
