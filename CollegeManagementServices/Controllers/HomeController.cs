using CollegeManagementServices.Data;
using CollegeManagementServices.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CollegeManagementServices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CollegeDbContext _context; // Add this field

        public HomeController(ILogger<HomeController> logger, CollegeDbContext context)
        {
            _logger = logger;
            _context = context; // Initialize context
        }
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        public IActionResult Staff()
        {
            var tasks = _context.StaffTasks.ToList(); // Fetch tasks from database
            return View(tasks); // Pass tasks to the view
        }


        public IActionResult Student()
        {
            var duties = _context.StudentDuties.ToList(); // Fetch duties from database
            return View("Student", duties); // Pass duties to the Student.cshtml view
        }

        public IActionResult Gamer()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
