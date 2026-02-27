using Academics.Business.Repository.Course;
using Academics.Business.Service.Course;
using Academics.DataModel;
using Common.Logging.Helper;

namespace Academics.Core.Service.Course
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public async Task<ResponseContext<int>> AddCourse(CourseRequestModel courseRequest)
        {
            var response = await _courseRepository.AddCourse(courseRequest);
            return response;
        }

        public async Task<ResponseContext<bool>> DeleteCourse(int courseId)
        {
            var response = await _courseRepository.DeleteCourse(courseId);
            return response;
        }

        public async Task<ResponseContext<CourseResponseModel>> GetAllCourses()
        {
            var response = await _courseRepository.GetAllCourses();
            return response;
        }

        public async Task<ResponseContext<CourseResponseModel>> GetCoursebyId(int courseId)
        {
            var response = await _courseRepository.GetCoursebyId(courseId);
            return response;
        }

        public async Task<ResponseContext<CourseResponseModel>> GetCoursebyNameorCode(string courseNameorCode)
        {
            var response = await _courseRepository.GetCoursebyNameorCode(courseNameorCode);
            return response;
        }

        public async Task<ResponseContext<CourseResponseModel>> UpdateCourse(CourseRequestModel courseRequest)
        {
            var response = await _courseRepository.UpdateCourse(courseRequest);
            return response;
        }
    }
}
