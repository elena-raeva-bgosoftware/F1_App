using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class DriverListViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Driver Number")]
        public int DriverNumber { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Team")]
        public string TeamName { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}
