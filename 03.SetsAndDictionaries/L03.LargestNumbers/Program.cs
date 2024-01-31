using System.Collections.Immutable;

namespace L03.LargestNumbers
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .ToArray();

            if (input.Length < 3)
            {
                foreach (var n in input)
                {
                    Console.Write(n + " ");
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}