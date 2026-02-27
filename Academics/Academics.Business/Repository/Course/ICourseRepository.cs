using Academics.DataModel;
using Common.Logging.Helper;

namespace Academics.Business.Repository.Course
{
    public interface ICourseRepository
    {
        Task<ResponseContext<int>> AddCourse(CourseRequestModel courseRequest);
        Task<ResponseContext<CourseResponseModel>> UpdateCourse(CourseResponseModel courseResponse);
        Task<ResponseContext<bool>> DeleteCourse(int courseId);
        Task<ResponseContext<CourseResponseModel>> GetCoursebyId(int courseId);
        Task<ResponseContext<CourseResponseModel>> GetCoursebyNameorCode(string courseNameorCode);
        Task<ResponseContext<IEnumerable<CourseResponseModel>>> GetAllCourses();

    }

    public interface IAssessmentRepository
    {
        Task<ResponseContext<int>> AddAssessment(AssessmentRequestModel assessmentRequest);
        Task<ResponseContext<AssessmentResponseModel>> UpdateAssessment(AssessmentResponseModel assessmentResponse);
        Task<ResponseContext<bool>> DeleteAssessment(int assessmentId);
        Task<ResponseContext<AssessmentResponseModel>> GetAssessmentbyId(int assessmenId);
        Task<ResponseContext<AssessmentResponseModel>> GetAssessmentbyType(string assessmentType);
        Task<ResponseContext<IEnumerable<AssessmentResponseModel>>> GetAllAssessments();

    }
}
