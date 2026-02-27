namespace Academics.DataModel
{
    public class AssessmentRequestModel
    {
        // public int AssessmentId { get; set; }

        public int CourseId { get; set; }
        public string Type { get; set; } = string.Empty; // e.g., "Term Exam", "Practical"
        public int Weightage { get; set; } // percentage contribution
        public DateTimeOffset Date { get; set; }
        public int Status { get; set; }//Soft delete status: 0 = active, 1 = deleted
        public int CreatedBy { get; set; }//Admin,Teacher, only     
        public DateTimeOffset CreatedAt { get; set; }

    }
}
