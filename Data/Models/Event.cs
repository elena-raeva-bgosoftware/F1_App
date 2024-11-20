using System.ComponentModel.DataAnnotations;

namespace F1_Web_App.Data.Models
{
    public class Event
    {
        public int Id { get; set; }

        public int  CircuitId { get; set; }

        public Circuit Circuit { get; set; }

        public DateTime EventDate { get; set; }

    }
}