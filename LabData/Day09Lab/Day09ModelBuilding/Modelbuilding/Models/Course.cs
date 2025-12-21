using System.ComponentModel.DataAnnotations;

namespace Modelbuilding.Models
{
    public class Course
    {

        public int CourseId { get; set; }

        [Required]
        [MaxLength(100)]
        public String CourseName { get; set; } = string.Empty;

        
        [MaxLength(500)]
        public String? Description { get; set; }

        [MaxLength(50)]
        public String ? Duration { get;set; }  // e.g "6 months

        public decimal Fees {  get; set; }

        public ICollection<CourseGroup> Groups { get; set; } = new List<CourseGroup>();
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
        public ICollection<Student> Students { get; set; } = new List<Student>();


    }
}
