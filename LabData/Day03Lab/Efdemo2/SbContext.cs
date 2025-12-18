using Microsoft.EntityFrameworkCore;

namespace Efdemo2
{
    class SbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(LocalDB)\\MSSQLLocalDB;Database=CollegeDB;Trusted_connection=True;");
        }



    }
}
