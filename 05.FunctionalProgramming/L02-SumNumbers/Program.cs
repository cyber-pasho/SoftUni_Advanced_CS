namespace L02_SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input  = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(input.Count());
            Console.WriteLine(input.Sum());
        }
    }
}