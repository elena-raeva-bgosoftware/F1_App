using System;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class Driver
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Range(1, 99, ErrorMessage = "Driver number must be between 1 and 99.")]
        public int DriverNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Team { get; set; } 

        [Required]
        [MaxLength(50)]
        public string Nationality { get; set; }  

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Wins count cannot be negative.")]
        public int Wins { get; set; } 
    }
}
