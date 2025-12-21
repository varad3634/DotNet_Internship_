using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ValidationDemo.Models
{
    public class SbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=StudentScapFold1DB;Trusted_Connection=True;");
        }
    }
}
