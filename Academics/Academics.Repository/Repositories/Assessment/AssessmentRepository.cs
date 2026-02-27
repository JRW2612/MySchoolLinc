using Academics.Business.Repository.Course;
using Academics.DataModel;
using Common.Logging.Helper;

namespace Academics.Repository.Repositories.Assessment
{
    public class AssessmentRepository : IAssessmentRepository
    {
        public Task<ResponseContext<int>> AddAssessment(AssessmentRequestModel assessmentRequest)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<bool>> DeleteAssessment(int assessmentId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<IEnumerable<AssessmentResponseModel>>> GetAllAssessments()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<AssessmentResponseModel>> GetAssessmentbyId(int assessmenId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<AssessmentResponseModel>> GetAssessmentbyType(string assessmentType)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseContext<AssessmentResponseModel>> UpdateAssessment(AssessmentResponseModel assessmentResponse)
        {
            throw new NotImplementedException();
        }
    }
}
