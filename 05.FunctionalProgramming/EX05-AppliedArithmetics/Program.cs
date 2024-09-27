using System;

namespace EX05_AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command;
            while ( (command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    nums = nums
                        .Select(Add)
                        .ToList();
                }
                else if (command == "multiply")
                {
                    nums = nums.Select(Multiply)
                        .ToList();
                }
                else if (command == "subtract")

                {
                    nums = nums.Select(Subtract)
                        .ToList();
                }
                else if(command == "print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
        public static int Add(int x)
        {
            return x + 1;
        }
        public static int Multiply(int x)
        {
            return x * 2;
        }
        public static int Subtract(int x)
        {
            return x - 1;
        }
    }
}
