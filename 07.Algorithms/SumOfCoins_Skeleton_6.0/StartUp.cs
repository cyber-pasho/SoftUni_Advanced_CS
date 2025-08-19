namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var coins = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var sum = int.Parse(Console.ReadLine());

            try
            {
                var chosenCoins = ChooseCoins(coins, sum);

                Console.WriteLine($"Number of coins to take: {chosenCoins.Values.Sum()}");

                foreach (var kvp in chosenCoins)
                {
                    Console.WriteLine($"{kvp.Value} coin(s) with value {kvp.Key}");
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Error: Cannot reach target sum.");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            var sortedCoins = coins.OrderByDescending(c => c).ToList();
            var result = new Dictionary<int, int>();

            foreach (var coin in sortedCoins) 
            {
                if (targetSum <= 0)
                {
                    break;
                }

                int count = targetSum / coin;
                if (count > 0) 
                {
                    result[coin] = count;
                    targetSum -= coin*count;
                }
            }
            if (targetSum > 0)
            {
                throw new InvalidOperationException("Cannot reach target sum with given coins.");
            }

            return result;
        }
    }
}