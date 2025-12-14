using System.ComponentModel.DataAnnotations;

namespace Assignment_3._1_solution
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        // One Student → Many Courses
        public List<Course> Courses { get; set; } = new List<Course>();
    }

}
