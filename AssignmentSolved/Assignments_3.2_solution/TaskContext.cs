using Microsoft.EntityFrameworkCore;

namespace Assignments_3._2_solution
{
    public class TaskContext : DbContext
    {
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=ManagerStaffTaskDB;Trusted_Connection=True;");
        }
    }
}
