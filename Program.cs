namespace lw1Practice
{
    public static class Program
    {
        public static void Main()
        {
            /*  Console.WriteLine("Hello, World!");
              var name = Console.ReadLine();
              Console.WriteLine(name);
            */
            Person person = new Person("Man");
            person.Name = "Daniil";
            Console.WriteLine(person.Name); 
        }
    }
}