using Microsoft.EntityFrameworkCore;

namespace Assignment_3._1_solution
{
    internal class Program
    {
        static SchoolContext db = new SchoolContext();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== STUDENT & COURSE MANAGEMENT =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course (Assign to Student)");
                Console.WriteLine("3. View All Students with Courses");
                Console.WriteLine("4. Update Course Name");
                Console.WriteLine("5. Delete Course");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddStudent(); break;
                    case 2: AddCourse(); break;
                    case 3: ViewStudents(); break;
                    case 4: UpdateCourse(); break;
                    case 5: DeleteCourse(); break;
                    case 6: return;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }

        // 1️ Add Student
        static void AddStudent()
        {
            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lname = Console.ReadLine();

            Student s = new Student
            {
                FirstName = fname,
                LastName = lname
            };

            db.Students.Add(s);
            db.SaveChanges();
            Console.WriteLine("Student added successfully!");
        }

        // 2️ Add Course
        static void AddCourse()
        {
            Console.Write("Enter Student ID: ");
            int sid = Convert.ToInt32(Console.ReadLine());

            Student student = db.Students.Find(sid);
            if (student == null)
            {
                Console.WriteLine("Student not found!");
                return;
            }

            Console.Write("Enter Course Name: ");
            string cname = Console.ReadLine();

            Course c = new Course
            {
                CourseName = cname,
                StudentId = sid
            };

            db.Courses.Add(c);
            db.SaveChanges();
            Console.WriteLine("Course added successfully!");
        }

        // 3️ View Students with Courses
        static void ViewStudents()
        {
            var students = db.Students
                             .Include(s => s.Courses)
                             .ToList();

            foreach (var s in students)
            {
                Console.WriteLine($"\nStudent ID: {s.StudentId}");
                Console.WriteLine($"Name: {s.FirstName} {s.LastName}");

                if (s.Courses.Count == 0)
                {
                    Console.WriteLine("  No Courses");
                }
                else
                {
                    foreach (var c in s.Courses)
                    {
                        Console.WriteLine($"  Course ID: {c.CourseId}, Name: {c.CourseName}");
                    }
                }
            }
        }

        // 4️ Update Course Name
        static void UpdateCourse()
        {
            Console.Write("Enter Course ID: ");
            int cid = Convert.ToInt32(Console.ReadLine());

            Course c = db.Courses.Find(cid);
            if (c == null)
            {
                Console.WriteLine("Course not found!");
                return;
            }

            Console.Write("Enter New Course Name: ");
            c.CourseName = Console.ReadLine();

            db.SaveChanges();
            Console.WriteLine("Course updated successfully!");
        }

        // 5️ Delete Course
        static void DeleteCourse()
        {
            Console.Write("Enter Course ID: ");
            int cid = Convert.ToInt32(Console.ReadLine());

            Course c = db.Courses.Find(cid);
            if (c == null)
            {
                Console.WriteLine("Course not found!");
                return;
            }

            db.Courses.Remove(c);
            db.SaveChanges();
            Console.WriteLine("Course deleted successfully!");
        }
    }
}
