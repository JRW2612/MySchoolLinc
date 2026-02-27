using Academics.Business.Repository.Course;
using Academics.DataModel;
using Common.Logging.Helper;

namespace Academics.Repository.Repositories.Course
{
    public class CourseRepository : ICourseRepository
    {
        public Task<ResponseContext<int>> AddCourse(CourseRequestModel courseRequest)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<bool>> DeleteCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<IEnumerable<CourseResponseModel>>> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<CourseResponseModel>> GetCoursebyId(int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<CourseResponseModel>> GetCoursebyNameorCode(string courseNameorCode)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<CourseResponseModel>> UpdateCourse(CourseResponseModel courseResponse)
        {
            throw new NotImplementedException();
        }
    }
}
