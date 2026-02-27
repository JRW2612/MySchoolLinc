namespace Academics.DataModel
{
    public class CourseResponseModel
    {
        public int CourseId { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Mathematics"
        public string Code { get; set; } = string.Empty; // CBSE subject code
        public int MaxMarks { get; set; } = 100;
        //   public ICollection<AssessmentRequestModel> Assessments { get; set; } = new List<AssessmentRequestModel>();

    }
}
