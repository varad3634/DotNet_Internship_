using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Internship\\Day04Lab\\MathsLibrary\\MathsLibrary\\bin\\Debug\\net8.0\\MathsLibrary.dll";
            Assembly assembly = Assembly.LoadFrom(path);

            Type[] allTypesInAssembly = assembly.GetTypes();
            foreach (Type type in allTypesInAssembly)
            {
                Console.WriteLine("Fullname : " + type.FullName);
                object dynamicObject = assembly.CreateInstance(type.FullName);
                Console.WriteLine(" Object created for type : "+type.FullName);


                



                MethodInfo[] allmethods = type.GetMethods();
                Console.WriteLine("Methods :");
                Console.WriteLine(" ");
                foreach (MethodInfo method in allmethods) 
                {
                    Console.WriteLine("--"+ 
                            method.ReturnType.ToString()
                            +" "+method.Name + "( " );

                    ParameterInfo[] allparams = method.GetParameters();
                    Object[] arguments = new Object[allparams.Length];
                    for (int i = 0;  i < allparams.Length;  i++)
                    {
                        ParameterInfo para = allparams[i];

                        Console.WriteLine("Enter the data of type   " + para.ParameterType.ToString()   + " for  " + para.Name + " " );

                        string data = Console.ReadLine();
                        arguments[i] = Convert.ChangeType(data,para.ParameterType);
                    }

                    object output = 
                        type.InvokeMember(method.Name,
                        BindingFlags.Public |
                        BindingFlags.Instance |
                        BindingFlags.InvokeMethod,
                        null, dynamicObject,arguments);
                    Console.WriteLine(output);
                    Console.WriteLine("---------------------");

                    //foreach (ParameterInfo para  in allparams)
                    //{
                    //    Console.WriteLine(para.ParameterType.ToString() +" " + para.Name + " ");
                    //}
                    //Console.WriteLine(")");
                    //Console.WriteLine();
                }
            }
            
        }
    }
}
