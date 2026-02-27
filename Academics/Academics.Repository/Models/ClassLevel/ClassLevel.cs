using Academics.Repository.Models.Course;

namespace Academics.Repository.Models.ClassLevel
{
    public class ClassLevels
    {
        public int ClassId { get; set; }
        public string Grade { get; set; } = string.Empty; // e.g., "Class 10"
        public ICollection<CourseModel> Courses { get; set; } = new List<CourseModel>();

    }
}
