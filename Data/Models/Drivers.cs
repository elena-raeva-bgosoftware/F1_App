using F1_Web_App.Common;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Data.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Driver number must be between 1 and 99.")]
        public int DriverNumber { get; set; }

        [Required]
        [MaxLength(ValidationConstants.DriverNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public int CountryId { get; set; }

        public Country Country { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        [Required]
        public bool IsRetired { get; set; }

        public ICollection<DriverSeason> DriverSeasons { get; set; } = new List<DriverSeason>();

        public ICollection<Result> Participations { get; set; } = new List<Result>();
    }
}