using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Academics.Repository.Models.Course
{
    [BsonIgnoreExtraElements] // Tells Mongo to ignore the auto-generated '_id' field
    public class AssessmentModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.Int64)]
        public int AssessmentId { get; set; }
        public int CourseId { get; set; }
        public string Type { get; set; } = string.Empty; // e.g., "Term Exam", "Practical"
        public int Weightage { get; set; } // percentage contribution
        public DateTimeOffset Date { get; set; }
        public int Status { get; set; }//Soft delete status: 0 = active, 1 = deleted

        public int CreatedBy { get; set; }//Admin,Teacher, only
        public int LastUpdatedBy { get; set; }//Admin,Teacher, only
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset LastUpdatedAt { get; set; }
    }
}
