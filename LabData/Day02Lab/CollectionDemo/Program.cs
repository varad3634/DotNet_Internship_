using System.Collections;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Non_generic legacy
            #region ArrayList
            ArrayList arr1 = new ArrayList();
            arr1.Add(1);  //int
            arr1.Add("fhjj");//string
            arr1.Add(true);//bool
            arr1.Add(new Employee());//object
            int i = (int)arr1[0];

            foreach (var j in arr1)
            {
                if (j is int k)

                    Console.WriteLine("int" + k);

                else if (j is string s)
                    Console.WriteLine("string" + s);
                else
                    Console.WriteLine("unknown" + j);
            }


            #endregion
            #region HashTable
            Hashtable h = new Hashtable();
            h.Add(1, "A");
            h.Add(2, "B");
            h.Add(3, "C");
            foreach (var item in h)
            {
                Console.WriteLine(item);
            }
            string s1 = (string)h[3];

            #endregion
            #endregion
            #region Generic
            #region List
            List<int> list = new List<int>();
            List<object> list2 = new List<object>();//ArrayList
            list.Add(1);
            //list.Add("fff");
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine("List is printing");

            foreach (var item in list)
            {
                Console.WriteLine(item);


            }

            List<string> list1 = new List<string>();
            #endregion

            #region Dictionary<K ,V>
            Dictionary<int, string> dlist = new Dictionary<int, string>();
            dlist.Add(1, "A");
            dlist.Add(2, "B");

            Console.WriteLine("printing dlist");
            foreach (var item in dlist)
            {
                Console.WriteLine(item);
            }
            string value = dlist[2];
            #endregion
            #endregion
            #region Collection initializer
            List<Employee> emplist = new List<Employee>
            {
                new Employee{Id=1,Name="a",Address="Pune"},
                new Employee{Id=2,Name="b",Address="Kop"},
                new Employee{Id=3,Name="c",Address="Satara"},
                new Employee{Id=4,Name="d",Address="Pune"},
                new Employee{Id=4,Name="e",Address="Pune"},

            };

            Employee e = new Employee { Id = 1, Name = "g", Address = "Pune" };

            Console.WriteLine("Employee list");
            foreach (var item in emplist)
            {
                //item.Display();
                if (item.Address.Contains("p", StringComparison.OrdinalIgnoreCase))
                    item.Display();
            }
            #endregion

        }
    }
    class Employee
    {
        //internally private string _name;
        public string Name { get; set; }  //auto-implemented properties
        //private field+public properties
        public int Id { get; set; }
        public string Address { get; set; }

        public void Display()
        {
            Console.WriteLine($"Id: {Id} Name:{Name} Address:-{Address}");
        }

    }
}