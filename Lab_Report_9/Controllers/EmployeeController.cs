using Lab_Report_9.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_Report_9.Controllers
{
    public class EmployeeController : Controller
    {
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
            if (!ModelState.IsValid)
            {
                // Redisplay the form with validation messages if data is invalid.
                return View(employee);
            }

            // Model Binding has already mapped the form fields to the Employee object.
            return View("Result", employee);
        }
    }
}