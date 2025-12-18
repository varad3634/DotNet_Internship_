namespace object_initializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Intialzer
            var e = new Employee { Salary = 5000 };
            // Employee e1 = new Employee(2, 7000);
            e.Display();
            int i = 100;  //int
            double d = 40.4;

            //implict type =>compile time
            var j = 200;
            var g = true;
            j = 300;
        }
    }


    class Employee
    {
        //internally private string _name;
        public string Name { get; set; }  //auto-implemented properties
        //private field+public properties
        public int Id { get; set; }
        public double Salary { get; set; }

        public void Display()
        {
            Console.WriteLine($"Id: {Id} Salary:-{Salary}");
        }

    }

}

