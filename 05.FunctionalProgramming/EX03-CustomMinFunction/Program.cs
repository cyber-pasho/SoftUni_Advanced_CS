namespace EX03_CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> func = i => i.Min();

            Console.WriteLine(func(input));
        }
    }
}
