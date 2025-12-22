namespace ConsoleApp1
{
    internal class Program
    {


        public static String GeneratePrn(int id)
        {
            string year = DateTime.Now.Year.ToString();
            string defaultCode = "1000";
            int temp = id;
            int s = 0;
            while (temp > 0)
            {
                temp /= 10;
                s++;
            }
            string sid = "";
            for (int i = 1; i <= 4 - s; i++)
            {
                sid += "0";
            }
            sid += id.ToString();
            return year + defaultCode + sid;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(GeneratePrn(1));
        }
    }
}
