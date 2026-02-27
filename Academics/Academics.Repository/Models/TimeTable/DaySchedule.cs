namespace Academics.Repository.Models.TimeTable
{
    public class DaySchedule
    {
        public int DayScheduleId { get; set; }
        public DayOfWeek Day { get; set; } // Enum: Monday, Tuesday, etc.
        public ICollection<Period> Periods { get; set; } = new List<Period>();

    }
}
