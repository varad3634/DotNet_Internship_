using System.ComponentModel.DataAnnotations;

namespace Modelbuilding.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(12)]
        public string PRN { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(15)]
        public string? MobileNo { get; set; }

        // FK
        public int CourseId { get; set; }

        public Course Course { get; set; } = null;

        public int CourseGroupId { get; set; }

        public CourseGroup CourseGroup { get; set; } = null;

        public ICollection<Marks> Marks { get; set; } = new List<Marks>();
        public string AppUserId { get; set; }
        public AppUser ApppUser { get; set; }



    }
}
