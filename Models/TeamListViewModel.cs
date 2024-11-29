using F1_Web_App.Data.Models;

namespace F1_Web_App.Models
{
    public class TeamListViewModel
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; } = null!;
        public string TeamImageUrl { get; set; } = null!;
        public ICollection<DriverListViewModel> Drivers { get; set; } = new List<DriverListViewModel>();

    }
}
