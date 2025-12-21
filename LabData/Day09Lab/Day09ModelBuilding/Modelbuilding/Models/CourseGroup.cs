using System.ComponentModel.DataAnnotations;

namespace Modelbuilding.Models
{
    public class CourseGroup
    {
        public int CourseGroupId { get; set; }

        [Required]
        [MaxLength(20)]
        public string GroupName { get; set; } = string.Empty;

        public int GroupSize { get; set; } = 10;

        public int CourseId { get; set; }
        public Course Course { get; set; } = null;

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
