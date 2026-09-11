using Microsoft.AspNetCore.Mvc;
using PREFINALS_EXAM.Models;

namespace PREFINALS_EXAM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new ExamViewModel
            {
                Questions = GetExamQuestions(),

            };
            return View(model);
        }

        private List<ExamItem> GetExamQuestions()
        {
            return new List<ExamItem>
            {
                new ExamItem { Id = 1, Category = "Relational Data Modeling & Model Binding", Question = "1. What is the main problem solved by using a database instead of an in-memory collection?", Options = new List<string>{ "A. It makes C# code shorter", "B. It prevents the application from restarting", "C. It allows data to persist after the application stops", "D. It removes the need for MVC" }, CorrectAnswer = 'C', AnswerText = "C. It allows data to persist after the application stops" },
                new ExamItem { Id = 2, Category = "Relational Data Modeling & Model Binding", Question = "2. Which approach is being used when an existing database is used to generate EF Core entity classes?", Options = new List<string>{ "A. Code-First", "B. Database-First", "C. Model-First", "D. Controller-First" }, CorrectAnswer = 'B', AnswerText = "B. Database-First" },
                new ExamItem { Id = 3, Category = "Relational Data Modeling & Model Binding", Question = "3. What is the primary purpose of Entity Framework Core?", Options = new List<string>{ "A. To create HTML pages automatically", "B. To replace the MVC Controller", "C. To map objects in code to relational database data", "D. To replace the C# compiler" }, CorrectAnswer = 'C', AnswerText = "C. To map objects in code to relational database data" },
                new ExamItem { Id = 4, Category = "Relational Data Modeling & Model Binding", Question = "4. Which EF Core component is primarily responsible for communicating with the database?", Options = new List<string>{ "A. DbContext", "B. DbSetView", "C. ControllerContext", "D. RazorContext" }, CorrectAnswer = 'A', AnswerText = "A. DbContext" },
                new ExamItem { Id = 5, Category = "Relational Data Modeling & Model Binding", Question = "5. What does the following command primarily do?\ndotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models", Options = new List<string>{ "A. Deletes the database", "B. Creates a new MVC project", "C. Generates EF Core models and a DbContext from an existing database", "D. Starts the MVC application" }, CorrectAnswer = 'C', AnswerText = "C. Generates EF Core models and a DbContext from an existing database" },
                new ExamItem { Id = 6, Category = "Conceptual Data Architecture & Razor Syntax", Question = "6. Where is a database connection string commonly stored in an ASP.NET Core MVC application?", Options = new List<string>{ "A. Program.cs only", "B. appsettings.json", "C. Index.cshtml", "D. Student.cs" }, CorrectAnswer = 'B', AnswerText = "B. appsettings.json" },
                new ExamItem { Id = 7, Category = "Conceptual Data Architecture & Razor Syntax", Question = "7. A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?", Options = new List<string>{ "A. One-to-One", "B. One-to-Many", "C. Many-to-Many", "D. Many-to-One only" }, CorrectAnswer = 'B', AnswerText = "B. One-to-Many" },
                new ExamItem { Id = 8, Category = "Conceptual Data Architecture & Razor Syntax", Question = "8. In the following example, what is SectionId?\npublic int SectionId { get; set; }\npublic Section Section { get; set; }", Options = new List<string>{ "A. Primary key of Student", "B. Foreign key referencing Section", "C. Navigation property", "D. Database connection string" }, CorrectAnswer = 'B', AnswerText = "B. Foreign key referencing Section" },









            };
        }
    }
}