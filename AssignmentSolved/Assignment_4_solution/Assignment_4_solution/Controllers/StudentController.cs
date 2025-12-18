using Assignment_4_solution.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment_4_solution.Controllers
{
    public class StudentController : Controller
    {
        StudentCourseContext sb = new StudentCourseContext();
        public IActionResult Index()
        {
            List<Student> students = sb.Students.Include(s=>s.Courses).ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            return View(); //Views/Student/Create.cshtml
        }

        public IActionResult AfterCreate(Student student,string CourseName)
        {
            Course course = new Course
            {
                CourseName = CourseName
            };
            student.Courses.Add(course);
            sb.Students.Add(student);
            sb.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Edit(int id)
        {


            Student s1 = sb.Students.
                          Include(s => s.Courses).
                          FirstOrDefault(s => s.StudentId == id);
            return View(s1); //Views/Student/Edit.cshtml
        }

        public IActionResult AfterEdit(Student s, string CourseName)
        {
            Student s1 = sb.Students
                .Include(x => x.Courses)
                .FirstOrDefault(x => x.StudentId == s.StudentId);

            if (s1 == null)
                return RedirectToAction("Index");

            s1.FirstName = s.FirstName;
            s1.LastName = s.LastName;

            var course = s1.Courses.FirstOrDefault();
            if (course != null)
            {
                course.CourseName = CourseName;
            }
            else
            {
                s1.Courses.Add(new Course { CourseName = CourseName });
            }

            sb.SaveChanges();
            return RedirectToAction("Index");
        }



        public IActionResult Delete(int id)
        {

            var s1 = sb.Students
           .Include(x => x.Courses)
           .FirstOrDefault(x => x.StudentId == id);

            if (s1 != null)
            {
                sb.Courses.RemoveRange(s1.Courses);
                sb.Students.Remove(s1);
                sb.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
