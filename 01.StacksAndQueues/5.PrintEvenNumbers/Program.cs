namespace _5.PrintEvenNumbers
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray();
            Queue<int> queue = new Queue<int>(input.Where(x => x % 2 == 0));
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}