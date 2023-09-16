namespace MatchingBrackets
{
    internal class Program
    {
        static void Main()
        {
            //1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            var input = Console.ReadLine();
                //.Where(c => !char.IsWhiteSpace(c))
                //.ToArray();
            Stack<int> opening = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    opening.Push(i);
                }
                else if (input[i] == ')')
                {
                    int start = opening.Pop();
                    string print = input.Substring(start, i-start+1);
                    Console.WriteLine(print);
                }
            }
        }
    }
}