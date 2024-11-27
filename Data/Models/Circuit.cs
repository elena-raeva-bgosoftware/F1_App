using System.ComponentModel.DataAnnotations.Schema;

namespace F1_Web_App.Data.Models
{
    public class Circuit
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int CountryId { get; set; }

        public Country Country { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public bool IsLegacy { get; set; }

 
    }
}