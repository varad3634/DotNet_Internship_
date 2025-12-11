using System;
using System.Net.NetworkInformation;

namespace Assignment_2_solution_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Given a list of integers: { 10, 2, 30, 4, 55, 60, 7, 8 }:

            Console.WriteLine("==>List of Integers==>");

            List<int> nums = new List<int> { 10, 2, 30, 4, 55, 60, 7, 8 };


            // a. Find all even numbers using LINQ.
            Console.WriteLine("Evens numbers :");

            var evens = from n in nums
                        where n % 2 == 0
                        select n;

            foreach (var n in evens)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(" ");

            // b.Find max, min, average
            Console.WriteLine("max ,min,average of list: ");
            int max = (from n in nums select n).Max();
            int min = (from n in nums select n).Min();
            double avg = (from n in nums select n).Average();


            Console.WriteLine("Max :" + max);
            Console.WriteLine("Min :" + min);
            Console.WriteLine("Avg :" + avg);

            Console.WriteLine("numbers greater than 20 sorted descending.");
            //c. Display numbers greater than 20 sorted descending.
            var result = from n in nums
                         where n > 20
                         orderby n descending
                         select n;
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            //6. Create a list of Employees (Id, Name, Dept, Salary). Using LINQ:
            Console.WriteLine("employee list\n");
            List<employee> listemp = new List<employee>(){
                 new employee{Id=1,Name="prafull",Dept="cse",Salary=200000},
                 new employee{Id=2,Name="adoph hitler",Dept="painter",Salary=50000000},
                 new employee{Id=3,Name="mao zedong",Dept="newspaper distributor",Salary=5000},
                 new employee{Id=4,Name="putin",Dept="spy",Salary=200000000},
                 new employee{Id=5,Name="bharat kadam",Dept="IT",Salary=250000},
                 new employee{Id=6,Name="vishwdeep kop samarthak",Dept="IT",Salary=200000}
                };

            //Using LINQ:
            //a.Print names of employees from 'IT' department.
            var result3 = from employee in listemp
                          where employee.Dept == "IT"
                          select employee;
            Console.WriteLine("Employees from IT Department:");
            foreach (var emp in result3)
            {
                Console.WriteLine(emp.Name);
            }
            //b. Find employee with highest salary.
            var result4 = listemp.Max(a => a.Salary);
            Console.WriteLine($"\nEmployees wih highest salary: {result4}");
            //c. Group employees by department.
            var result5 = from emp in listemp
                          group emp by emp.Dept into g
                          select new
                          {
                              Department = g.Key,
                              Employees = g
                          };

            foreach (var group in result5)
            {
                Console.WriteLine("Department: " + group.Department);

                foreach (var emp in group.Employees)
                {
                    Console.WriteLine("  " + emp.Name);
                }
            }
            List<student> students = new List<student>() {
            new student { Id = 1, Name = "Rohan" },
             new student { Id = 2, Name = "Priya" }
                };

            List<mark> marks = new List<mark>() {
              new mark { Id = 1, Sub = "Math", Score = 90 },
              new mark { Id = 1, Sub = "Science", Score = 85 },
             new mark { Id = 2, Sub = "Math", Score = 95 }
            };

            // 7. Join two lists
            Console.WriteLine("\n7 join two list\n");
            var result6 = from s in students      // List1
                          join m in marks         // List2
                          on s.Id equals m.Id
                          select new
                          {
                              StudentName = s.Name,
                              Subject = m.Sub,
                              Score = m.Score
                          };

            foreach (var item in result6)
            {
                Console.WriteLine($"{item.StudentName} - {item.Subject} - {item.Score}");
            }

           /* 8.Create a list of strings(city names). Using LINQ, return only names which start with 'P'
            and have length > 5.*/
            Console.WriteLine("\n8 .city names\n");
            List<string> cities = new List<string>
            {
                    "Pune", "Panvel", "Patna", "Paris", "Palghar", "Mumbai"
            };

            var result7 = from c in cities
                         where c.StartsWith("P") && c.Length > 5
                         select c;

            foreach (var city in result7)
            {
                Console.WriteLine(city);
            }

        }
        class employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }
            public int Salary { get; set; }
        }
        class student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        class mark
        {
            public int Id { get; set; }
            public string Sub { get; set; }
            public int Score { get; set; }
        }

    }


}
