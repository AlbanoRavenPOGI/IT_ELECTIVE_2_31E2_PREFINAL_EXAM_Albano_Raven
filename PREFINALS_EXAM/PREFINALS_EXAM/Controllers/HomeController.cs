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
                TosData = GetTosData()
            };
            return View(model);
        }

        private List<ExamItem> GetExamQuestions()
        {
            return new List<ExamItem>
            {
                new ExamItem { Id = 1, Category = "Relational Data Modeling & Model Binding", Question = "1. What is the main problem solved by using a database instead of an in-memory collection?", Options = new List<string>{ "A. It makes C# code shorter", "B. It prevents the application from restarting", "C. It allows data to persist after the application stops", "D. It removes the need for MVC" }, CorrectAnswer = 'C', AnswerText = "C. It allows data to persist after the application stops" },

            };
        }

        private List<TosRow> GetTosData()
        {
            return new List<TosRow>
            {
                new TosRow { Cilo = "Develop relational database models and ER diagrams. Perform model binding in ASP.NET Core MVC.", Tlo = "Apply relational model concepts including tables, keys, and constraints; implement basic model binding", Content = "Relational Data Modeling (Tables, Keys, and Constraints); Model Binding and Controller Actions", ItemCount = 5, ItemPlacement = "1, 2, 3, 4, 5" },
                new TosRow { Cilo = "Create Entity-Relationship Diagrams (ERD); render data dynamically using Razor; apply loops and conditions in views", Tlo = "Render data dynamically using Razor; apply loops and conditions in views", Content = "Conceptual Data Architecture: Designing ERDs; Razor Syntax and Dynamic Rendering", ItemCount = 5, ItemPlacement = "6, 7, 8, 9, 10" },
                new TosRow { Cilo = "Understand the role of information systems and databases in validation; apply normalization rules (1NF, 2NF, 3NF)", Tlo = "Apply normalization rules (1NF, 2NF, 3NF) to design efficient data structures", Content = "Data Normalization & Structural Integrity (1NF, 2NF, 3NF); Data Validation and ModelState", ItemCount = 5, ItemPlacement = "11, 12, 13, 14, 15" },
                new TosRow { Cilo = "Perform CRUD operations using in-memory data; understand data persistence conceptually", Tlo = "Perform CRUD operations using in-memory data", Content = "Introduction to Structured Query Language (SQL); In-Memory Data Storage and CRUD Operations", ItemCount = 5, ItemPlacement = "16, 17, 18, 19, 20" }
            };
        }
    }
}