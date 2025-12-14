using System.ComponentModel.DataAnnotations;

namespace Assignments_3._2_solution
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        // Foreign Key
        public int ManagerId { get; set; }

        // Navigation Property
        public Manager Manager { get; set; }

        // One Staff → Many Tasks
        public List<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
