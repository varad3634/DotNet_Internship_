using Microsoft.AspNetCore.Mvc;
using MvcDemo1.Models;
using System.Diagnostics;

namespace MvcDemo1.Controllers
{
    public class HomeController : Controller
    {
        StudentContext sb = new StudentContext();

        public IActionResult Index()
        {
            List<Student>slists=sb.Students.ToList();
            return View(slists);
        }

        public IActionResult Create()
        {
            return View(); //Views/Home/Create.cshtml
        }

        public IActionResult AfterCreate(Student s)
        {
            sb.Students.Add(s);
            sb.SaveChanges();
            return Redirect("/Home/Index");
        }

        public IActionResult Edit(int id)
        {

            Student s1 = sb.Students.Find(id);
            return View(s1); //Views/Student/Edit.cshtml
        }

        public IActionResult AfterEdit(Student s)
        {

            Student s1 = sb.Students.Find(s.StudentId);
            s1.StudentName = s.StudentName;
            s1.CourseId = s.CourseId;
            s1.CourseName = s.CourseName;
            sb.SaveChanges();

            return Redirect("/Home/Index");
        }

        public IActionResult Delete(int id)
        {

            Student s1 = sb.Students.Find(id);
            sb.Students.Remove(s1);
            sb.SaveChanges();

            return Redirect("/Home/Index");
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
