namespace Assignment_1_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the roll number :");
            int roll_no= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the age :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the course :");
            string course = Console.ReadLine();

            Student s1 = new Student(name,roll_no,age,course);
            s1.display();
           
        }
    }

    class Student
    {
        private string _name;
        private int _roll_no;
        private int _age;
        private string _course;

        public Student(string name, int roll_no, int age, string course)
        {
            this._name = name;
            this._roll_no = roll_no;
            this._age = age;
            this._course = course;
        }

        public void display()
        { 
            Console.WriteLine($"Name = {_name} Roll_no = {_roll_no} " +
                $"Age = {_age} Course = {_course}");
        }
    }
}
