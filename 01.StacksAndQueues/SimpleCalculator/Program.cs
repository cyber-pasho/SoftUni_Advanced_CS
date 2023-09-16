namespace SimpleCalculator
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ")
                .Reverse()
                .ToList();
            Stack<string> stack = new Stack<string>();
            foreach (var item in input)
            {
                stack.Push(item);
            }
            int sum = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                string operation = stack.Pop();
                if (operation == "+")
                {
                    int number = int.Parse(stack.Pop());
                    sum += number;
                }
                else if (operation == "-")
                {
                    int number = int.Parse(stack.Pop());
                    sum -= number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}