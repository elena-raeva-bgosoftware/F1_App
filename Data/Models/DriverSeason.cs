using F1_Web_App.Common;
using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Data.Models
{
    public class DriverSeason
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int? ContractedTeamId { get; set; }

        [Required]
        [Range(1950, 2100, ErrorMessage = "The value should be a valid year, that the formula could happen")]
        public int Year { get; set; }

        public Team ContractedTeam { get; set; } = null!;

        [Range(1, 99, ErrorMessage = "Driver number must be between 1 and 99.")]
        public int SpecialNumber { get; set; }

    }
}