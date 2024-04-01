using Microsoft.AspNetCore.Mvc;
using study_mvc.Models;
using System.Diagnostics;

namespace study_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Student student = new Student();
            student.age = 1;
            student.name = "Test";
            student.sex = "123";
            return View(student);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
