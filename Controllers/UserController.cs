using Microsoft.AspNetCore.Mvc;
using MinimalRESTAPI.Models;
using MinimalRESTAPI.Services;

namespace MinimalRESTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        // POST: api/users/register
        [HttpPost("register")]
        public IActionResult Register([FromBody] User newUser)
        {
            // Ensure email is unique
            if (DataService.Users.Any(u => u.Email == newUser.Email))
            {
                return BadRequest(new { Response = "Email already exists" });
            }

            // Assign a unique ID to the user
            newUser.Id = DataService.Users.Count + 1;

            // Add the new user to the list
            DataService.Users.Add(newUser);

            return Ok(new { Response = "User registered successfully", UserId = newUser.Id });
        }


        // POST: api/users/login
        [HttpPost("login")]
        public IActionResult Login([FromBody] User loginUser)
        {
            // Check if the user exists
            var user = DataService.Users.FirstOrDefault(u => u.Email == loginUser.Email && u.Password == loginUser.Password);

            if (user == null)
            {
                return Unauthorized(new { Response = "Invalid email or password" });
            }

            // Return a dummy token for successful login
            return Ok(new { Response = "Login successful", Token = "dummy-token" });
        }

        // GET: api/users
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(DataService.Users);
        }

    }
}
