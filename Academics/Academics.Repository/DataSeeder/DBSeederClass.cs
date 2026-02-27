using Academics.Repository.Models.Course;
using Academics.Repository.Models.TimeTable;
using MongoDB.Driver;
using System.Text.Json;

namespace Academics.Repository.DataSeeder
{
    public class DBSeederClass
    {
        public static async Task SeedDataAsync(Constants constants)
        {
            var _connection = new MongoClient(constants.ConnectionString);
            var db = _connection.GetDatabase(constants.DatabaseName);
            var courses = db.GetCollection<CourseModel>(constants.CoursesCollectionName);
            var assessments = db.GetCollection<AssessmentModel>(constants.AssesmentsCollectionName);
            var timetables = db.GetCollection<TimeTable>(constants.TimeTablesCollectionName);

            var seedBasePath = Path.Combine(AppContext.BaseDirectory, "DataSeeder");

            //Seed Brands
            List<CourseModel> courseList = new List<CourseModel>();
            if ((await courses.CountDocumentsAsync(_ => true)) == 0)
            {
                var courseData = await File.ReadAllTextAsync(Path.Combine(seedBasePath, "Courses.json"));
                courseList = JsonSerializer.Deserialize<List<CourseModel>>(courseData);
                foreach (var p in courseList)
                {
                    //Reset Id to let mongo add new one
                    if (p.CourseId == 0)
                    {
                        //Daefault CreatedDate if not set
                        if (p.CreatedAt == default)
                        {
                            p.CreatedAt = DateTime.UtcNow;
                        }
                    }
                }

                await courses.InsertManyAsync(courseList);
            }
            else
            {
                var existingCourses = await courses.Find(_ => true).ToListAsync();
            }

            //Seed Types
            List<AssessmentModel> assessmentsList = new List<AssessmentModel>();
            if ((await assessments.CountDocumentsAsync(_ => true)) == 0)
            {

                var assessmentsData = await File.ReadAllTextAsync(Path.Combine(seedBasePath, "Assessments.json")); assessmentsList = JsonSerializer.Deserialize<List<AssessmentModel>>(assessmentsData);
                foreach (var al in assessmentsList)
                {
                    //Reset Id to let mongo add new one
                    if (al.AssessmentId == 0)
                    {
                        //Daefault CreatedDate if not set
                        if (al.CreatedAt == default)
                        {
                            al.CreatedAt = DateTime.UtcNow;
                        }
                    }
                }
                await assessments.InsertManyAsync(assessmentsList);
            }
            else
            {
                var existingAssessments = await assessments.Find(_ => true).ToListAsync();
            }

            ////Seed Products
            //List<Product> productList = new List<Product>();
            //if ((await products.CountDocumentsAsync(_ => true)) == 0)
            //{
            //    var productData = await File.ReadAllTextAsync(Path.Combine(SeedBasePath, "products.json"));
            //    productList = JsonSerializer.Deserialize<List<Product>>(productData);
            //    foreach (var p in productList)
            //    {
            //        //Reset Id to let mongo add new one
            //        p.Id = null;
            //        //Daefault CreatedDate if not set
            //        if (p.CreatedDate == default)
            //        {
            //            p.CreatedDate = DateTimeOffset.UtcNow;
            //        }
            //    }
            //    await products.InsertManyAsync(productList);
            //}
            //else
            //{
            //    var existingProducts = await products.Find(_ => true).ToListAsync();
            //}
        }
    }
}
