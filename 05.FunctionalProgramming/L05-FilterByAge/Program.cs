namespace L05_FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ReadPeople();

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
            Action<Person> printer = CreatePrinter(format);
            PrintFilteredPeople(people, filter, printer);
        }
        // Implement the method to read people
        public static List<Person> ReadPeople()
        {
            int N = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                string[] parts = input.Split(", ");
                string name = parts[0].Trim('[', ']');
                int age = int.Parse(parts[1].Trim('[', ']'));
                people.Add(new Person(name, age));
            }
            return people;
        }
        // Implement the method to create a filter
        public static Func<Person, bool> CreateFilter( string condition, int ageThreshold)
        {
            if (condition == "younger")
            {
                return person => person.Age < ageThreshold;
            }
            else if (condition == "older")
            {
                return person => person.Age >= ageThreshold;
            }
            else
            {
                throw new ArgumentException("Invalid condition");
            }
        }
        // Implement the method to create a printer
        public static Action<Person> CreatePrinter(string format)
        {
            if (format == "name")
            {
                return person => Console.WriteLine(person.Name);
            }
            else if (format == "age")
            {
                return person => Console.WriteLine(person.Age);
            }
            else if (format == "name age")
            {
                return person => Console.WriteLine($"{person.Name} - {person.Age}");
            }
            else
            {
                throw new ArgumentException("Invalid format");
            }
        }
        // Implement the method to print filtered people
        public static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            foreach (var person in people)
            {
                if (filter(person))
                {
                    printer(person);
                }
            }
        }
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
