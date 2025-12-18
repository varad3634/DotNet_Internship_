using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Student
    {
        [Key]
        public int Roll_no { get; set; }
        public string Name { get; set; }
        public int Course_id { get; set; }
    }
}
