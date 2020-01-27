using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LibraryApi.Services;
namespace DemoApi.Controllers
{
    public class StatusController : Controller
    {
        IGenerateEnrollmentIds EnrollmentGenerator;

        public StatusController(IGenerateEnrollmentIds enrollmentGenerator)
        {
            EnrollmentGenerator = enrollmentGenerator;
        }


        // GET /status
        [HttpGet("/status")]
        public IActionResult GetTheStatus()
        {
            var response = new ServerStatus
            {
                Id = 99,
                StatusMessage = "All Clear",
                CheckedAt = DateTime.Now
            };
            return Ok(response);
        }

        // Using Route Data
        // GET /blogs/2019/12/20 
        [HttpGet("/blogs/{year:int:min(2015)}/{month:int:range(1,12)}/{day:int:range(1,31)}")]
        public IActionResult GetBlogPostsFor(int year, int month, int day)
        {
            return Ok($"Giving the blog posts for {day}/{month}/{year}");
        }

        // GET /employees?dept=dev
        [HttpGet("/employees")]
        public IActionResult GetEmployeesForDepartment([FromQuery]string dept = "all")
        {
            return Ok("Getting employees for department " + dept);
        }

        [HttpGet("/whoami")]
        public IActionResult WhoAmi([FromHeader(Name = "User-Agent")]string ua)
        {
            return Ok("I see you are running " + ua);
        }

        [HttpPost("/enrollments")]
        public IActionResult AddEnrollment([FromBody] EnrollmentRequest request)
        {
            var id = EnrollmentGenerator.GetNewId();
            
            return Ok($"[{id}]: You are enrolled for {request.ClassEnrolledFor} for {request.NumberOfDays} ({request.Student})");
        }
    }


    public class EnrollmentRequest
    {
        [JsonPropertyName("class")]
        public string ClassEnrolledFor { get; set; }
        public string Student { get; set; }
        public int NumberOfDays { get; set; }
    }


    public class ServerStatus
    {
        public int Id { get; set; }
        public string StatusMessage { get; set; }
        public DateTime CheckedAt { get; set; }
    }
}
