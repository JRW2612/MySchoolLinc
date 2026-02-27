namespace Academics.DataModel
{
    public class CourseResponseModel
    {
        public int CourseId { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Mathematics"
        public string Code { get; set; } = string.Empty; // CBSE subject code
        public int MaxMarks { get; set; } = 100;
        //   public ICollection<AssessmentRequestModel> Assessments { get; set; } = new List<AssessmentRequestModel>();
        public int Status { get; set; }//Soft delete status: 0 = active, 1 = deleted
        public int CreatedBy { get; set; }//Admin,Teacher, only       
        public DateTimeOffset CreatedAt { get; set; }
        public int LastUpdatedBy { get; set; }//Admin,Teacher, only
        public DateTimeOffset LastUpdatedAt { get; set; }
    }
}
