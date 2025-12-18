namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Manager();
            e.Accept();
            e.Display();
            Console.WriteLine("Salary" + e.CalSalary());
            e.DoWork();
            Console.WriteLine("1.Manager\n  2.SalesManager");
            Employee e1 = null;
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    e1 = new Manager();

                    break;
                case 2:
                    e1 = new SalesManager();
                    break;

            }
            if (e1 != null)
                e1.Accept();
            e1.Display();
        }
    }

    abstract class Employee
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public virtual double CalSalary()
        {
            return Salary;
        }
        public abstract void DoWork();

        public virtual void Accept()
        {
            Console.WriteLine("Enter the Id: ");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary");
            this.Salary = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine($"Id: {Id} Salary:-{Salary}");
        }


    }

    class Manager : Employee
    {
        private double _bonus;

        public double Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }

        public override double CalSalary()
        {
            return Salary + Bonus;
        }
        public override void DoWork()
        {
            Console.WriteLine("Manages work");
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the bonus");
            this.Bonus = Convert.ToDouble(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Bonus:{Bonus}");
        }

    }

    class SalesManager : Employee
    {
        private double _comm;

        public double Comm
        {
            get { return _comm; }
            set { _comm = value; }
        }
        public override double CalSalary()
        {
            return Salary + Comm;
        }
        public override void DoWork()
        {
            Console.WriteLine("Manage Marketing");
        }

    }
}
