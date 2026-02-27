namespace Academics.DataModel
{
    public class AssessmentResponseModel
    {
        public int AssessmentId { get; set; }
        public int CoursetId { get; set; }
        public string Type { get; set; } = string.Empty; // e.g., "Term Exam", "Practical"
        public int Weightage { get; set; } // percentage contribution
        public DateTime Date { get; set; }
        public int Status { get; set; }//Soft delete status: 0 = active, 1 = deleted  
        public DateTime LastUpdatedBy { get; set; }//Admin,Teacher, only
        public DateTime LastUpdatedAt { get; set; }
    }
}
