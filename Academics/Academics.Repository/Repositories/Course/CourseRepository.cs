using Academics.Business.Repository.Course;
using Academics.DataModel;
using Academics.Repository.DataSeeder;
using Academics.Repository.Models.Course;
using Common.Logging.Helper;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;

namespace Academics.Repository.Repositories.Course
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IMongoCollection<CourseModel> _courses;
        private readonly IMongoCollection<AssessmentModel> _assessments;

        public CourseRepository(Constants constants)
        {
            var _connection = new MongoClient(constants.ConnectionString);
            var db = _connection.GetDatabase(constants.DatabaseName);
            _courses = db.GetCollection<CourseModel>(constants.CoursesCollectionName);
            _assessments = db.GetCollection<AssessmentModel>(constants.AssesmentsCollectionName);
            //  _types = db.GetCollection<ProductType>(constants.TypesCollectionName);
        }

        public async Task<ResponseContext<int>> AddCourse(CourseRequestModel courseRequest)
        {
            var response = new ResponseContext<int>();
            // Map CourseRequestModel -> CourseModel to satisfy the collection's document type
            try
            {
                var courses = await _courses.Find(_ => true).ToListAsync(); // Fetch all courses
                // Map CourseModel to CourseResponseModel
                var courseResponses = new List<CourseModel>();
                foreach (var course in courses)
                {
                    courseResponses.Add(new CourseModel
                    {
                        CourseId = course.CourseId,
                        Name = course.Name,
                        Code = course.Code,
                        MaxMarks = course.MaxMarks,
                        Status = course.Status,
                        CreatedBy = course.CreatedBy,
                        CreatedAt = course.CreatedAt
                    });
                }

                // Set the response with the fetched customer data
                if (courses != null)
                {
                    response.Item = 1; // Assuming response has an Item property
                    response.StatusCode = (int)StatusCodes.Status200OK;
                }
                else
                {
                    response.Item = 0;
                    response.StatusCode = (int)StatusCodes.Status404NotFound;
                }
            }
            catch
            {
                response.Item = 0;
                response.StatusCode = (int)StatusCodes.Status501NotImplemented;
            }

            return response;
        }

        public async Task<ResponseContext<bool>> DeleteCourse(int courseId)
        {
            var response = new ResponseContext<bool>();

            try
            {
                var update = Builders<CourseModel>.Update
                            .Set(x => x.Status, 0);

                var result = await _courses.UpdateOneAsync(
                            x => x.CourseId == courseId,
                            update);

                response.Item = result.ModifiedCount > 0;
                response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception ex)
            {
                response.Item = false;
                response.StatusCode = StatusCodes.Status500InternalServerError;
            }

            return response;
        }

        public async Task<ResponseContext<CourseResponseModel>> GetAllCourses()
        {
            var response = new ResponseContext<CourseResponseModel>();

            try
            {
                var courses = await _courses.Find(_ => true).ToListAsync();

                var result = courses.Select(course => new CourseResponseModel
                {
                    CourseId = course.CourseId,
                    Name = course.Name,
                    Code = course.Code,
                    MaxMarks = course.MaxMarks,
                    Status = course.Status,
                    CreatedBy = course.CreatedBy,
                    CreatedAt = course.CreatedAt
                });

                response.Items = result;
                response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception ex)
            {
                response.Items = null;
                response.StatusCode = StatusCodes.Status500InternalServerError;

            }

            return response;
        }

        public Task<ResponseContext<CourseResponseModel>> GetCoursebyId(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<CourseResponseModel>> GetCoursebyNameorCode(string courseNameorCode)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<CourseResponseModel>> UpdateCourse(CourseRequestModel courseRequest)
        {
            throw new NotImplementedException();
        }
    }
}
