namespace ExceptionDemo.Filters
{
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException(string message):base(message) 
        {
        }
    }
}
