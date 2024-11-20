using F1_Web_App.Data.Models;

public class EventViewModel
{
    public int Id { get; set; }
    public string CircuitName { get; set; } = null!;
    public string Country { get; set; } = null!;
    public DateTime EventDate { get; set; }
    public string ImageUrl { get; set; } = null!;
}
