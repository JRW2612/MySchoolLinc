using MongoDB.Bson.Serialization.Attributes;

namespace Academics.Repository.Models.Course
{
    [BsonIgnoreExtraElements] // Tells Mongo to ignore the auto-generated '_id' field
    public class CourseModel
    {
        public int CourseId { get; set; }
        public string Name { get; set; } = string.Empty; // e.g., "Mathematics"
        public string Code { get; set; } = string.Empty; // CBSE subject code
        public int MaxMarks { get; set; } = 100;

        public int Status { get; set; } //Soft delete status: 0 = active, 1 = deleted
        public int CreatedBy { get; set; } //Admin,Teacher, only

        // Changed from DateTime to int to match CreatedBy
        public int LastUpdatedBy { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset LastUpdatedAt { get; set; }
    }

}

