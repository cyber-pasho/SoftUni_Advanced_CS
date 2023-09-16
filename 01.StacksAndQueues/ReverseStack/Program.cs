namespace ReverseStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>(Console.ReadLine());
            while (stack.Count > 0)
            {
                char result = stack.Pop();
                Console.Write(result);
            }
        }
    }
}