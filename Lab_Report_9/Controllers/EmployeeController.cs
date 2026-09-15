using Microsoft.AspNetCore.Mvc;
using Lab_Report_9.Models;

namespace Lab_Report_9.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            return View("Result", employee);
        }
    }
}