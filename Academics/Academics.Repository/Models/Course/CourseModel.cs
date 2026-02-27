namespace Academics.Repository.Models.Course
{
    public class CourseModel
    {
        public int CourseId { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Mathematics"
        public string Code { get; set; } = string.Empty; // CBSE subject code
        public int MaxMarks { get; set; } = 100;
        //public ICollection<AssessmentModel> Assessments { get; set; } = new List<AssessmentModel>();
    }

}

