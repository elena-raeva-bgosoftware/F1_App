using System;
using System.ComponentModel.DataAnnotations;

namespace F1_App.Data.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DriverNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string Team { get; set; }

        [Url]
        public string PhotoUrl { get; set; }
    }
}
