using Microsoft.AspNetCore.Mvc;
using MinimalRESTAPI.Services;
using MinimalRESTAPI.Models;

namespace MinimalRESTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        // GET: api/courses
        [HttpGet]
        public IActionResult GetCourses()
        {
            var courses = DataService.Courses;
            return Ok(courses);
        }

        // POST: api/courses/enroll
        [HttpPost("enroll")]
        public IActionResult Enroll([FromBody] Enrollment enrollment)
        {
            // Validate user existence
            var userExists = DataService.Users.Any(u => u.Id == enrollment.UserId);
            if (!userExists)
            {
                return BadRequest(new { Response = "Invalid User ID" });
            }

            // Validate course existence
            var courseExists = DataService.Courses.Any(c => c.Id == enrollment.CourseId);
            if (!courseExists)
            {
                return BadRequest(new { Response = "Invalid Course ID" });
            }

            // Check if the user is already enrolled in the course
            var alreadyEnrolled = DataService.Enrollments.Any(e => e.UserId == enrollment.UserId && e.CourseId == enrollment.CourseId);
            if (alreadyEnrolled)
            {
                return BadRequest(new { Response = "User is already enrolled in this course" });
            }

            // Enroll the user in the course
            DataService.Enrollments.Add(enrollment);

            return Ok(new { Response = "Enrollment successful" });
        }
    }
}
