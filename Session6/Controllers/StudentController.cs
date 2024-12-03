using Microsoft.AspNetCore.Mvc;
using Session6.Models;

namespace Session6.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult AddStudent()
        { 
            return View();
        }
        [HttpPost]
		public IActionResult AddStudent(string name,string phoneNumber)
		{
            var context = new AppDbContext();
            var student = new Student
            {
                Name = name,
                PhoneNumber = phoneNumber
            };
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("Index","Home");
		}
	}
}
