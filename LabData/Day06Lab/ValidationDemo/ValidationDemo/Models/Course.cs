namespace ValidationDemo.Models
{
    public class Course
    {

        public int CourseId { get; set; }


        public string CourseName { get; set; }
        List<Student> Students { get; set; } = new List<Student>();

    }
}
