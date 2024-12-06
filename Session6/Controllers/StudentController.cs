using Microsoft.AspNetCore.Mvc;
using Session6.Models;
using Session6.Models.ViewModels;

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
		public IActionResult AddStudent(StudentViewModel std)
		{
            if(ModelState.IsValid)
            {
                var context = new AppDbContext();
                var student = new Student
                {
                    Name = std.Name,
                    PhoneNumber = std.PhoneNumber

                };
                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(std);
            
            

           
		}
	}
}
