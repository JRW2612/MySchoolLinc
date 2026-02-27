using Academics.Business.Service.Course;
using Academics.DataModel;
using Common.Logging.Helper;
using Microsoft.AspNetCore.Mvc;

namespace Academics.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CoursesController(ICourseService courseServic)
        {
            _courseService = courseServic;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseContext<CourseRequestModel>>> GetAllCourses()
        {
            var response = await _courseService.GetAllCourses();
            return Ok(response);
        }


        #region Add Course
        [HttpPost]
        public async Task<ActionResult<ResponseContext<CourseResponseModel>>> AddOrEditCourse([FromBody] CourseRequestModel courseRequest)
        {
            if (courseRequest.CourseId == 0)
            {
                var response = await _courseService.AddCourse(courseRequest);

                return Ok(response);
            }
            else
            {
                var response = await _courseService.UpdateCourse(courseRequest);

                return Ok(response);
            }

        }
        #endregion

        [HttpDelete("{courseId}")]
        public async Task<ActionResult<ResponseContext<bool>>> DeleteCourse([FromBody] int courseId)
        {
            if (courseId > 0)
            {
                var response = await _courseService.DeleteCourse(courseId);

                return Ok(response);
            }
            return BadRequest();
        }


    }
}