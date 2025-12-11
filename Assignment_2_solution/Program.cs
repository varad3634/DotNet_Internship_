namespace Assignment_2_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("====>> Part A ");
            Console.WriteLine("\n=========list===========\n");
            /*
            1. Create a class `Book` with properties:
            Id, Title, Author, Price. 
            Add 10 books to a `List<Book> */

            List<Book> books = new List<Book>()
            {
                new Book{Id=101,Title="maratha",Author="j.kulkurni",Price=250},
                new Book{Id=102,Title="aai",Author="sawant",Price=150},
                new Book{Id=103,Title="shiva",Author="desai",Price=950},
                new Book{Id=104,Title="shambhaji maharaj",Author="kadam",Price=550},
                new Book{Id=105,Title="lakh marathe",Author="more",Price=240},
                new Book{Id=106,Title="social",Author="shinde",Price=550},
                new Book{Id=107,Title="environ",Author="pol",Price=180},
                new Book{Id=108,Title="sports",Author="sankpal",Price=350},
                new Book{Id=109,Title="farmer",Author="bhosale",Price=290},
                new Book{Id=110,Title="political",Author="kutke",Price=350}
            };

            // 1 => a.Display all books ordered by Price(ascending).

            Console.WriteLine("books price in ascending");
            books.Sort((a, b) => a.Price.CompareTo(b.Price));

            foreach (var item in books)
            {
                Console.WriteLine($"book_id = {item.Id} , Title = {item.Title} , Author = {item.Author} , Price = {item.Price}");
            }

            //1 => b. Display all books where Author name contains letter 'a'
            Console.WriteLine("");
            Console.WriteLine("Author contains a letter");
            foreach (var item in books)
            {
                if (item.Author.Contains("a", StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine($"book_id = {item.Id}, Title = {item.Title} , Author = {item.Author} ,Price = {item.Price}");
            }


            // 1 => c. Remove a book whose Id is given by user
            Console.WriteLine("");
            bool flag = false;
            Console.WriteLine("Enter the book Id you want to delete : ");
            int n = Convert.ToInt32(Console.ReadLine());
            foreach (var item in books)
            {
                if (item.Id == n && flag == false)
                {
                    books.Remove(item);
                    flag = true;
                    Console.WriteLine("deletion Done");
                    break;
                }
            }
            foreach (var item in books)
            {
                Console.WriteLine($"book_id = {item.Id} , Title = {item.Title} , Author = {item.Author} , Price = {item.Price}");
            }


            Console.WriteLine(" ");
            Console.WriteLine("\n========Dictionary===========\n");
            //2. Using Dictionary<int, string>, store student roll numbers and names

            Dictionary<int, string> studdict = new Dictionary<int, string>()
            {
                {1, "Aarav"},
                {2, "Zoya"},
                {3, "Bhushan"},
                {4, "Chitra"},
                {5, "Deepak"},
                {6, "Anjali"},
                {7, "Ramesh"},
                {8, "Sneha"},
                {9, "Pratik"},
                {10, "Kiran"}
            };

            //  2 => a. Search and display student name if roll number is provided.

            Console.WriteLine("Enter the roll no to search :");
            int num = Convert.ToInt32(Console.ReadLine());
            if (studdict.ContainsKey(num))
            {
                Console.WriteLine($"Student name = {studdict[num]}");
            }
            else
            {
                Console.WriteLine("the roll no not found");
            }

            // 2 =>  b. Print all entries in alphabetical order of names.

            Console.WriteLine("Print all entries in alphabetical order of names. ");
            List<string> students = new List<string>();
            foreach (var item in studdict)
            {
                students.Add(item.Value);
            }
            Console.WriteLine("======> Names before sorting ========== ");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            students.Sort();
            Console.WriteLine("======> Names after sorting =========== ");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

        class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }

            public string Author { get; set; }

            public int Price { get; set; }
        }
        class Student
        {
            public int Roll_no_ { get; set; }

            public string Name { get; set; }

        }






    }
}
    