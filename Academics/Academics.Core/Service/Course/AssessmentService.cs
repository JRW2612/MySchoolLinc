using Academics.Business.Repository.Course;
using Academics.Business.Service.Course;
using Academics.DataModel;
using Common.Logging.Helper;
namespace Academics.Core.Service.Course
{
    public class AssessmentService : IAssessmentService
    {
        private readonly IAssessmentRepository _assessmentRepository;
        public AssessmentService(IAssessmentRepository assessmentRepository)
        {
            _assessmentRepository = assessmentRepository;
        }
        public async Task<ResponseContext<int>> AddAssessment(AssessmentRequestModel assessmentRequest)
        {
            var response = await _assessmentRepository.AddAssessment(assessmentRequest);
            return response;
        }

        public async Task<ResponseContext<bool>> DeleteAssessment(int assessmentId)
        {
            var response = await _assessmentRepository.DeleteAssessment(assessmentId);
            return response;
        }

        public async Task<ResponseContext<AssessmentResponseModel>> GetAllAssessments()
        {
            var response = await _assessmentRepository.GetAllAssessments();
            return response;
        }

        public async Task<ResponseContext<AssessmentResponseModel>> GetAssessmentbyId(int assessmenId)
        {
            var response = await _assessmentRepository.GetAssessmentbyId(assessmenId);
            return response;
        }

        public async Task<ResponseContext<AssessmentResponseModel>> GetAssessmentbyType(string assessmentType)
        {
            var response = await _assessmentRepository.GetAssessmentbyType(assessmentType);
            return response;
        }

        public async Task<ResponseContext<AssessmentResponseModel>> UpdateAssessment(AssessmentResponseModel assessmentResponse)
        {
            var response = await _assessmentRepository.UpdateAssessment(assessmentResponse);
            return response;
        }
    }
}
