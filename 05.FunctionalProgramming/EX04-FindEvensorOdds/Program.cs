namespace EX04_FindEvensorOdds
{
    internal class Program
    {
        static void Main()
        {
            var range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string condition = Console.ReadLine();
            Predicate<int> predicate = condition == "odd" ? IsOdd : IsEven;
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (predicate(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}