using System.ComponentModel.DataAnnotations;

namespace F1_App.Data.Models
{
    public class F1History
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1950, 2024)]
        public int Year { get; set; }

        [Required]
        public string ChampionDriver { get; set; }

        [Required]
        public string ChampionTeam { get; set; }

        public int NumberOfRaces { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
