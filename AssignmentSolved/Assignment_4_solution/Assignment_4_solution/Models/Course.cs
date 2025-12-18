using System.ComponentModel.DataAnnotations;

namespace Assignment_4_solution.Models
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
