using F1_Web_App.Data.Models;

namespace F1_Web_App.Models
{
    public class ResultsEditViewModel
    {
        public int EventId { get; set; }

        public ICollection<ResultEditViewModel> Results { get; set; } = new List<ResultEditViewModel>();

        public ICollection<DriverListViewModel> DriverListViewModels { get; set; } = new List<DriverListViewModel>();
    }
}
