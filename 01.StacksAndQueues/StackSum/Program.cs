namespace StackSum
{
    internal class Program
    {
        static void Main()
        {
            var initialInput = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            string commands;
            while ((commands = Console.ReadLine().ToLower())!= "end")
            {
                if (commands.Contains("add"))
                {
                    var numbers = commands
                        .Split(" ")
                        .ToList();
                    for (int i = 1; i < numbers.Count; i++)
                    {
                        initialInput.Push(int.Parse(numbers[i]));
                    }
                }
                else if (commands.Contains("remove"))
                {
                    var numbers = commands
                        .Split(" ")
                        .ToList();
                    if (initialInput.Count >= int.Parse(numbers[1]))
                    {
                        for (int i = 1; i <= int.Parse(numbers[1]); i++)
                        {
                            initialInput.Pop();
                        }
                    }
                }
            }
            int sum = 0;
            while (initialInput.Count > 0)
            {
                int num = (initialInput.Pop());
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}