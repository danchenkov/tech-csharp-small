namespace IQuittable
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee josh = new Employee();
            josh.FirstName = "Josh";
            josh.LastName = "Smith";
            josh.Quit();
        }
    }
}
