using Microsoft.EntityFrameworkCore;

namespace Assignment_4_solution.Models
{
    public class StudentCourseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=StudentCourseMSDbMVC;Trusted_Connection=True;");
        }
    }
}
