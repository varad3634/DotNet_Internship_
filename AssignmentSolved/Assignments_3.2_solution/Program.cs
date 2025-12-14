using Microsoft.EntityFrameworkCore;
namespace Assignments_3._2_solution
{
    internal class Program
    {
        static TaskContext db = new TaskContext();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== MANAGER & STAFF TASK MANAGEMENT =====");
                Console.WriteLine("1. Add Manager");
                Console.WriteLine("2. Add Staff (Assign to Manager)");
                Console.WriteLine("3. Add Task (Assign to Staff)");
                Console.WriteLine("4. View All Managers, Staff & Tasks");
                Console.WriteLine("5. Update Task (Mark as Completed)");
                Console.WriteLine("6. Delete Task");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddManager(); break;
                    case 2: AddStaff(); break;
                    case 3: AddTask(); break;
                    case 4: ViewAll(); break;
                    case 5: UpdateTask(); break;
                    case 6: DeleteTask(); break;
                    case 7: return;
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }

        // 1️ Add Manager
        static void AddManager()
        {
            Console.Write("Enter Manager Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Manager m = new Manager
            {
                Name = name,
                Email = email
            };

            db.Managers.Add(m);
            db.SaveChanges();
            Console.WriteLine("Manager added successfully!");
        }

        // 2️ Add Staff
        static void AddStaff()
        {
            Console.Write("Enter Manager ID: ");
            int mid = Convert.ToInt32(Console.ReadLine());

            if (db.Managers.Find(mid) == null)
            {
                Console.WriteLine("Manager not found!");
                return;
            }

            Console.Write("Enter Staff Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Staff Email: ");
            string email = Console.ReadLine();

            Staff s = new Staff
            {
                Name = name,
                Email = email,
                ManagerId = mid
            };

            db.Staffs.Add(s);
            db.SaveChanges();
            Console.WriteLine("Staff added successfully!");
        }

        // 3️ Add Task
        static void AddTask()
        {
            Console.Write("Enter Staff ID: ");
            int sid = Convert.ToInt32(Console.ReadLine());

            if (db.Staffs.Find(sid) == null)
            {
                Console.WriteLine("Staff not found!");
                return;
            }

            Console.Write("Enter Task Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Description: ");
            string desc = Console.ReadLine();

            TaskItem t = new TaskItem
            {
                Title = title,
                Description = desc,
                IsCompleted = false,
                StaffId = sid
            };

            db.TaskItems.Add(t);
            db.SaveChanges();
            Console.WriteLine("Task assigned successfully!");
        }

        // 4️ View All Data (Include & ThenInclude)
        static void ViewAll()
        {
            var managers = db.Managers
                .Include(m => m.Staffs)
                    .ThenInclude(s => s.Tasks)
                .ToList();

            foreach (var m in managers)
            {
                Console.WriteLine($"\nManager: {m.Name} ({m.Email})");

                foreach (var s in m.Staffs)
                {
                    Console.WriteLine($"  Staff: {s.Name} ({s.Email})");

                    foreach (var t in s.Tasks)
                    {
                        Console.WriteLine($"    Task: {t.Title} | Completed: {t.IsCompleted}");
                    }
                }
            }
        }

        // 5️ Update Task
        static void UpdateTask()
        {
            Console.Write("Enter Task ID: ");
            int tid = Convert.ToInt32(Console.ReadLine());

            TaskItem t = db.TaskItems.Find(tid);
            if (t == null)
            {
                Console.WriteLine("Task not found!");
                return;
            }

            t.IsCompleted = true;
            db.SaveChanges();
            Console.WriteLine("Task marked as completed!");
        }

        // 6️⃣ Delete Task
        static void DeleteTask()
        {
            Console.Write("Enter Task ID: ");
            int tid = Convert.ToInt32(Console.ReadLine());

            TaskItem t = db.TaskItems.Find(tid);
            if (t == null)
            {
                Console.WriteLine("Task not found!");
                return;
            }

            db.TaskItems.Remove(t);
            db.SaveChanges();
            Console.WriteLine("Task deleted successfully!");
        }
    }
}
