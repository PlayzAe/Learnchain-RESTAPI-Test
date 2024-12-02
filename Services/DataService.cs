using MinimalRESTAPI.Models;

namespace MinimalRESTAPI.Services
{
    public class DataService
    {
        // In-memory users list
        public static List<User> Users { get; } = new List<User>();

        // In-memory courses list
        public static List<Course> Courses { get; } = new List<Course>
        {
            new Course { Id = 1, Title = "Advanced C#", Description = "Master C# programming." },
            new Course { Id = 2, Title = "Web Development with ASP.NET", Description = "Learn to build websites using ASP.NET." }
        };

        // In-memory enrollments list
        public static List<Enrollment> Enrollments { get; } = new List<Enrollment>();
    }
}
