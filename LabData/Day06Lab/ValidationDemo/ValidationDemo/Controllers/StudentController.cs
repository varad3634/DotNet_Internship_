using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    public class StudentController : Controller
    {
        public static SbContext sb = new SbContext();
        public IActionResult Index()
        {
            var slist = sb.Students.Include(c => c.Course).ToList();
            return View(slist);
        }
        public IActionResult Create()
        {
            var clist = sb.Courses.ToList();
            ViewBag.Courses = new SelectList(clist, "CourseId", "CourseName");
            return View();
        }

        public IActionResult AfterCreate(Student s)
        {
            sb.Students.Add(s);
            sb.SaveChanges();
            return Redirect("/Student/Index");
        }


    }
}
