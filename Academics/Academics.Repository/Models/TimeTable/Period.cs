using Academics.Repository.Models.Course;

namespace Academics.Repository.Models.TimeTable
{
    public class Period
    {
        public int PeriodId { get; set; }
        public int PeriodNumber { get; set; } // e.g., 1st, 2nd, 3rd
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        // Relationships
        public CourseModel? Course { get; set; }
        public int TeacherId { get; set; }
        public string Room { get; set; } = string.Empty; // e.g., "Room 101"

    }
}
