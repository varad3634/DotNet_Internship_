using System.ComponentModel.DataAnnotations;

namespace ValidationDemo.Models
{

        public class Student
        {

            public int StudentId { get; set; }

            
           
            public string StudentName { get; set; }

            
            public string StudentEmail { get; set; }

    
            public int CourseId { get; set; }

            public Course Course { get; set; }
        }
    
}
