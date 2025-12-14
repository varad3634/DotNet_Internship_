using System.ComponentModel.DataAnnotations;

namespace Assignments_3._2_solution
{
    public class TaskItem
    {
        [Key]
        public int TaskItemId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        // Foreign Key
        public int StaffId { get; set; }

        // Navigation Property
        public Staff Staff { get; set; }
    }
}
