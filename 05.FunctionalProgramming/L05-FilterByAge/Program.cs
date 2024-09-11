namespace L05_FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Person> people = ReadPeople();

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            //Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
            //Action<Person> printer = CreatePrinter(format);
            //PrintFilteredPeople(people, filter, printer);
        }
        // Implement the method to read people
        // Implement the method to create a filter
        // Implement the method to create a printer
        // Implement the method to print filtered people
    }
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
