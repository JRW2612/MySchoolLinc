namespace Academics.Repository.Models.TimeTable
{
    public class SpecialEvent
    {
        public int EventId { get; set; }
        public string Title { get; set; } = string.Empty; // e.g., "Annual Day"
        public DateTime EventDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Venue { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
