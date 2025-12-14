using System.ComponentModel.DataAnnotations;

namespace Assignments_3._2_solution
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        // One Manager → Many Staff
        public List<Staff> Staffs { get; set; } = new List<Staff>();
    }
}
