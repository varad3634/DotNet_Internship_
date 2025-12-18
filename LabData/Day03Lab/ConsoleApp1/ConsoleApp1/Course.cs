using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Course
    {
        [Key]
        public int Course_id { get; set; }
        public string Course_name { get; set; }
    }
}
