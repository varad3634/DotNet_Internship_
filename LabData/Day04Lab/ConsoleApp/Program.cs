using MathsLibrary;
using System.Runtime.InteropServices;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice=0;
            Console.WriteLine("1.Addition \n2.Substraction ");
            Console.WriteLine("Enter the choice :");
            choice = Convert.ToInt32(Console.ReadLine());
            var calc = new MathsLibrary.Maths();
            switch (choice)
            { 
                case 1:
                    Console.WriteLine("Enter the value of a :");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of b :");
                    int b = Convert.ToInt32(Console.ReadLine());
                    int add = calc.Add(a, b);
                    Console.WriteLine($"Addition : {add} ");
                    break;
                case 2:
                    Console.WriteLine("Enter the value of c :");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the value of d :");
                    int d = Convert.ToInt32(Console.ReadLine());
                    int sub = calc.Subtract(c, d);
                    Console.WriteLine($"Subtract :{sub}");
                    break;
                 default:
                    Console.WriteLine("Enter the valid choice");
                    break;

            }
        }
    }
}
