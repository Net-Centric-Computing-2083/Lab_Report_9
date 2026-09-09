using Microsoft.AspNetCore.Mvc;
using ModelBindingDemo.Models;

namespace ModelBindingDemo.Controllers
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