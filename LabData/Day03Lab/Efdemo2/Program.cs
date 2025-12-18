using Microsoft.EntityFrameworkCore;

namespace Efdemo2
{
    internal class Program
    {
        static SbContext sb = new SbContext();

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- Student & Course Management ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course (Assign to Student)");
                Console.WriteLine("3. View All Students with Courses");
                Console.WriteLine("4. Update Course Name");
                Console.WriteLine("5. Delete Course");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;

                    case 2:
                        AddCourse();
                        break;

                    case 3:
                        ViewStudentsWithCourses();
                        break;

                    case 4:
                        UpdateCourse();
                        break;

                    case 5:
                        DeleteCourse();
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 6);
        }

        // 1. Add Student
        static void AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Student s = new Student
            {
                Name = name,
                Age = age
            };

            sb.Students.Add(s);
            sb.SaveChanges();

            Console.WriteLine("Student added successfully");
        }

        // 2. Add Course
        static void AddCourse()
        {
            Console.Write("Enter Course Name: ");
            string cname = Console.ReadLine();

            Console.Write("Enter Student Id: ");
            int sid = Convert.ToInt32(Console.ReadLine());

            Student s = sb.Students.Find(sid);
            if (s == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            Course c = new Course
            {
                CourseName = cname,
                StudentId = sid
            };

            sb.Courses.Add(c);
            sb.SaveChanges();

            Console.WriteLine("Course added successfully");
        }

        // 3. View Students with Courses
        static void ViewStudentsWithCourses()
        {
            var students = sb.Students
                             .Include(x => x.Courses)
                             .ToList();

            foreach (var s in students)
            {
                Console.WriteLine($"\nStudent Id: {s.StudentId}, Name: {s.Name}, Age: {s.Age}");

                if (s.Courses.Count == 0)
                {
                    Console.WriteLine("  No courses enrolled");
                }
                else
                {
                    foreach (var c in s.Courses)
                    {
                        Console.WriteLine($"  Course Id: {c.CourseId}, Course Name: {c.CourseName}");
                    }
                }
            }
        }

        // 4. Update Course Name
        static void UpdateCourse()
        {
            Console.Write("Enter Course Id: ");
            int cid = Convert.ToInt32(Console.ReadLine());

            Course c = sb.Courses.Find(cid);
            if (c == null)
            {
                Console.WriteLine("Course not found");
                return;
            }

            Console.Write("Enter new Course Name: ");
            c.CourseName = Console.ReadLine();

            sb.SaveChanges();
            Console.WriteLine("Course updated successfully");
        }

        // 5. Delete Course
        static void DeleteCourse()
        {
            Console.Write("Enter Course Id: ");
            int cid = Convert.ToInt32(Console.ReadLine());

            Course c = sb.Courses.Find(cid);
            if (c == null)
            {
                Console.WriteLine("Course not found");
                return;
            }

            sb.Courses.Remove(c);
            sb.SaveChanges();

            Console.WriteLine("Course deleted successfully");
        }
    }
}
