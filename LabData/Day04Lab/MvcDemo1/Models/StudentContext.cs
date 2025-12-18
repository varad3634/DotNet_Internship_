using Microsoft.EntityFrameworkCore;

namespace MvcDemo1.Models
{
    class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=StudentMVCDb;Trusted_Connection=True;");
        }
    }
}
