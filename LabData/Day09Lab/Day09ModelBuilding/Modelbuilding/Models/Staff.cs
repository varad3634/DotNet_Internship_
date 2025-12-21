using System.ComponentModel.DataAnnotations;

namespace Modelbuilding.Models
{
    public class Staff
    {
        public int StaffId { get; set; }

        // public int empcode{get;set;} // e.g. 4003

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = String.Empty;

        
        [MaxLength(10)]
        public String? Mobile {  get; set; }

        public ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();

        public string AppUserId {  get; set; }
        public AppUser AppUser { get; set; }
    }
}
