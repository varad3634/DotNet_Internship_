namespace ArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{arr[i]}]");
            }

            int[] arr1 = new int[4];
            Console.WriteLine("Enter the value");
            for (int i = 0; i < arr1.Length; i++)
            {

                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("printing the value...");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"arr[{arr1[i]}]");
            }
        }
    }
}
