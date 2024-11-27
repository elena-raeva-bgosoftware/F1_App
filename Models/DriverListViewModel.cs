using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Models
{
    public class DriverListViewModel
    {
        public int Id { get; set; }

        public int DriverNumber { get; set; }

        public string Name { get; set; } = string.Empty;

        public string TeamName { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}
