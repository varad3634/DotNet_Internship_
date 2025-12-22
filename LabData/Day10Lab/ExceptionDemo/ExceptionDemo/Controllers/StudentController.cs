using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using ExceptionDemo.Models;
using ExceptionDemo.Filters;

namespace ExceptionDemo.Controllers
{
    public class StudentController : Controller
    {


        private static List<Student> students = new()
        {
            new Student{Id =1,Name ="Rahul",Email =" rahul@gmail.com",CourseId = 101}
        };

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Details(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == 2);
            if(student == null)
            {
                throw new StudentNotFoundException("Student record not found !!!!!!!!!!!!!!!!!!");
            }

            
                return View(student);
        }

    }
}
