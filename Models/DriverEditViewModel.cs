using F1_Web_App.Data.Models;

namespace F1_Web_App.Models
{
    public class DriverEditViewModel
    {
        public int Id { get; set; }

        public string DriverName { get; set; }

        public int DriverNumber { get; set; }

        public int TeamId { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<TeamListViewModel> Teams { get; set; } = new List<TeamListViewModel>();

        public ICollection<DriverListViewModel> Drivers { get; set; } = new List<DriverListViewModel>();
    }
}
