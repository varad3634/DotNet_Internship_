namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Address = "Mumbai", CourseId = 101 },
            new Student { Id = 2, Name = "Bob", Address = "Pune", CourseId = 102 },
            new Student { Id = 3, Name = "Charlie", Address = "Delhi", CourseId = 101 },
            new Student { Id = 4, Name = "Anita", Address = "Mumbai", CourseId = 103 }
        };
            var courses = new List<Course>
        {
            new Course { CourseId = 101, CourseName = "Math" },
            new Course { CourseId = 102, CourseName = "Science" },
            new Course { CourseId = 103, CourseName = "English" }
        };

            var slist = from stud in students

                        select stud;

            var slist1 = from stud1 in students
                         where stud1.CourseId > 101
                         select stud1;//select * from students

            var slist2 = from s1 in students
                         where s1.CourseId > 101
                         select new { s1.Name, s1.CourseId };


            foreach (var item in slist2)
            {
                //Console.WriteLine($"Id:{item.Id} Name:{item.Name} Addresss:{item.Address} CourseId:{item.CourseId}");
                Console.WriteLine($" Name:{item.Name}  CourseId:{item.CourseId}");
            }



        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CourseId { get; set; }
    }

    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
