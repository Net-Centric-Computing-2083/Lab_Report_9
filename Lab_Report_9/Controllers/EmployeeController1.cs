using Microsoft.AspNetCore.Mvc;
using Lab_Report_9.Models;

namespace Lab_Report_9.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                return View("Result", employee);
            }

            return View(employee);
        }
    }
}