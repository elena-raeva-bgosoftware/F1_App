using System;
using F1_Web_App.Common;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
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
        [MaxLength(ValidationConstants.DriverTeamNameMaxLength)]
        public string Team { get; set; } = null!;

        [Required]
        [MaxLength(ValidationConstants.DriverNationalityMaxLength)]
        public string Nationality { get; set; } = null!;

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Wins count cannot be negative.")]
        public int Wins { get; set; }
    }
}
