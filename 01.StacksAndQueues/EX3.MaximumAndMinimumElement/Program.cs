namespace EX3.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main()
        {
            int queries = int.Parse(Console.ReadLine());
            Stack<int> nums = new Stack<int>();
            for (int i = 1; i <= queries; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .ToArray();
                if (int.Parse(input[0]) == 1)
                {
                    nums.Push(int.Parse(input[1]));
                }
                else if (int.Parse(input[0]) == 2)
                {
                    nums.Pop();
                }
                else if (int.Parse(input[0]) == 3)
                {
                    if (nums.Count == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(nums.Max());
                }
                else
                {
                    if (nums.Count == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(nums.Min());
                }
            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}