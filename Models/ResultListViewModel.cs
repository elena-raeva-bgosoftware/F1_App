namespace F1_Web_App.Models
{
    public class ResultListViewModel
    {
        public string CircuitName { get; set; }

        public DateTime EventDate { get; set; }

        public ICollection<ResultViewModel> Results { get; set; }
    }
}
