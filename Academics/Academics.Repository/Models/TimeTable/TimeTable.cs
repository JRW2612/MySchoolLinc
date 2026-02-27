using Academics.Repository.Models.ClassLevel;

namespace Academics.Repository.Models.TimeTable
{
    public class TimeTable
    {
        public int TimeTableId { get; set; }
        public ClassLevels? Class { get; set; }
        public ICollection<DaySchedule> DaySchedules { get; set; } = new List<DaySchedule>();

    }
}
