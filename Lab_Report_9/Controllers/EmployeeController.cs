using Lab_Report_9.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_Report_9.Controllers
{
    public class EmployeeController : Controller
    {
        // Temporary storage for submitted employee
        private static Employee submittedEmployee;

        // GET: /Employee/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Employee/Create
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            submittedEmployee = employee;

            return RedirectToAction("Details");
        }

        // GET: /Employee/Details
        [HttpGet]
        public IActionResult Details()
        {
            if (submittedEmployee == null)
            {
                return Content("No employee information has been submitted yet.");
            }

            return View(submittedEmployee);
        }
    }
}