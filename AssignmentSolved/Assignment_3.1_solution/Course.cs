using System.ComponentModel.DataAnnotations;

namespace Assignment_3._1_solution
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        // Foreign Key
        public int StudentId { get; set; }

        // Navigation Property
        public Student Student { get; set; }
    }

}
