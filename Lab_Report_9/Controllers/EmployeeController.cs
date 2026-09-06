using Microsoft.AspNetCore.Mvc;
using LabReport9.Models;

namespace LabReport9.Controllers
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