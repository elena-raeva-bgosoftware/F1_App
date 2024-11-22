namespace F1_Web_App.Data.Models
{
    public class Result
    {
        public int Id { get; set; }

        public int Points { get; set; }

        public int DriverId { get; set; }

        public Driver Driver { get; set; }

        public int EventId { get; set; }

        public Event Event { get; set; }

    }
}
