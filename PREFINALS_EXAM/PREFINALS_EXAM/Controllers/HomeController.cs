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
            };
        }
    }
}