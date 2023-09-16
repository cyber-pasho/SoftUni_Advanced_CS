namespace EX1.BasicStackOperations
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();
            Stack<string> nums = new Stack<string>(Console.ReadLine().Split());
            for (int i = 1; i <= int.Parse(input[1]); i++) 
            {
                nums.Pop();
            }
            if (nums.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if (nums.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(nums.Min());
            }
        }
    }
}