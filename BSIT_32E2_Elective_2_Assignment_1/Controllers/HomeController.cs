using Microsoft.AspNetCore.Mvc;
using BSIT_32E2_Elective_2_Assignment_1.Models;

namespace BSIT_32E2_Elective_2_Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questionList = new List<Questions>
            {
                new Questions
                {
                    Id = 1,
                    Topic = "Architecture",
                    Prompt = "What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?",
                    Choices = new[]
                    {
                        "A) SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server.",
                        "B) SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON.",
                        "C) SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers.",
                        "D) SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server."
                    },
                    Answer = "B) SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON."
                },
                new Questions
                {
                    Id = 2,
                    Topic = "Controllers",
                    Prompt = "Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller?",
                    Choices = new[]
                    {
                        "A) ControllerBase supports Razor View rendering using View() and ViewData.",
                        "B) ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead.",
                        "C) Controller is obsolete in .NET 8 and cannot handle HTTP POST requests.",
                        "D) ControllerBase automatically creates SQLite database files on application startup."
                    },
                    Answer = "B) ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead."
                },
                new Questions
                {
                    Id = 3,
                    Topic = "Validation",
                    Prompt = "Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?",
                    Choices = new[]
                    {
                        "A) [Route]",
                        "B) [HttpGet]",
                        "C) [ApiController]",
                        "D) [FromQuery]"
                    },
                    Answer = "C) [ApiController]"
                },
                new Questions
                {
                    Id = 4,
                    Topic = "HTTP Status Codes",
                    Prompt = "Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?",
                    Choices = new[]
                    {
                        "A) 200 OK",
                        "B) 201 Created",
                        "C) 204 No Content",
                        "D) 404 Not Found"
                    },
                    Answer = "B) 201 Created"
                },
                new Questions
                {
                    Id = 5,
                    Topic = "HTTP Status Codes",
                    Prompt = "When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?",
                    Choices = new[]
                    {
                        "A) 200 OK",
                        "B) 201 Created",
                        "C) 204 No Content",
                        "D) 400 Bad Request"
                    },
                    Answer = "C) 204 No Content"
                },
                new Questions
                {
                    Id = 6,
                    Topic = "RESTful Naming",
                    Prompt = "Which of the following endpoint URIs follows RESTful resource-oriented naming best practices?",
                    Choices = new[]
                    {
                        "A) GET /api/getAllCourses",
                        "B) GET /api/courses",
                        "C) POST /api/createNewCourseRecord",
                        "D) POST /api/deleteCourseById?id=5"
                    },
                    Answer = "B) GET /api/courses"
                },
                new Questions
                {
                    Id = 7,
                    Topic = "Routing",
                    Prompt = "What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?",
                    Choices = new[]
                    {
                        "A) It connects the controller directly to an Entity Framework database context.",
                        "B) It maps incoming URI request paths to the controller class using the class name token.",
                        "C) It encrypts all incoming JSON payloads.",
                        "D) It enables Cross-Origin Resource Sharing (CORS) for external React apps."
                    },
                    Answer = "B) It maps incoming URI request paths to the controller class using the class name token."
                },
                new Questions
                {
                    Id = 8,
                    Topic = "HTTP Methods",
                    Prompt = "Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?",
                    Choices = new[]
                    {
                        "A) POST",
                        "B) PUT",
                        "C) GET",
                        "D) DELETE"
                    },
                    Answer = "C) GET"
                },
                new Questions
                {
                    Id = 9,
                    Topic = "Return Types",
                    Prompt = "In ASP.NET Core Web API, what wrapper type allows action methods to return either a strongly typed domain object or standard HTTP status result helpers (such as Ok(), NotFound())?",
                    Choices = new[]
                    {
                        "A) Task<IActionResult>",
                        "B) ActionResult<T>",
                        "C) ViewResult",
                        "D) JsonResult"
                    },
                    Answer = "B) ActionResult<T>"
                }
            };

            return View(questionList);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
