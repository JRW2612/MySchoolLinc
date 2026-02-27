namespace Academics.DataModel
{
    public class AssessmentRequestModel
    {
        // public int AssessmentId { get; set; }

        public int CourseId { get; set; }
        public string Type { get; set; } = string.Empty; // e.g., "Term Exam", "Practical"
        public int Weightage { get; set; } // percentage contribution
        public DateTime Date { get; set; }
    }
}
