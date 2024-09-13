namespace EX01_ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ")
                .ToArray();

            Action<string> print = name => Console.WriteLine($"Sir {name}");
            foreach (var person in input)
            {
                print(person);
            }
        }
    }
}
