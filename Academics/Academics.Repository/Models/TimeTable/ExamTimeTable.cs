using Academics.Repository.Models.Course;

namespace Academics.Repository.Models.TimeTable
{
    public class ExamTimeTable
    {
        public int ExamTimeTableId { get; set; }
        public string ExamName { get; set; } = string.Empty; // e.g., "Term 1", "Board Exam"
        public DateTime ExamDate { get; set; }
        public CourseModel? Course { get; set; }
        public string Room { get; set; } = string.Empty;
        public int InvigilatorId { get; set; }
        public int MaxMarks { get; set; }

    }
}
