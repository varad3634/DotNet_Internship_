using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Efdemo2
{
    [Table("Course2")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; } // primary key
        public string CourseName { get; set; }

        // Foreign key 

        public int StudentId { get; set; }

        // Navigation Property
        
        public Student Student { get; set; }

    }
}
