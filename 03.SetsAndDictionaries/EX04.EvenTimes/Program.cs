using System.Linq;

namespace EX04.EvenTimes
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            Dictionary<int,int> numbers = new Dictionary<int,int>();
            for (int i = 0; i < size; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(input))
                {
                    numbers.Add(input, 1);
                }
                else
                {
                    numbers[input]++;
                }
            }
            var answer = numbers.FirstOrDefault(x=>x.Value%2==0);
            Console.WriteLine(answer.Key);
        }
   1