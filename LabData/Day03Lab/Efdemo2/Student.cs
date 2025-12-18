using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Efdemo2
{
    [Table("Student2")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; } // primary  key
        public string Name { get; set; }

        public int Age { get; set; }

        public List<Course> Courses { get; set; }


    }
}
