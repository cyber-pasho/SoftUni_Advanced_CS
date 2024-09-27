namespace EX06_ReverseandExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();
            int divisor = int.Parse(Console.ReadLine());
            var filteredNumbers = input
                .Where(num => !IsDivisible(num, divisor))
                .ToList();
            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
        static bool IsDivisible(int number1, int number2)
        {
            return number1 % number2 == 0;
        }
    }
}
