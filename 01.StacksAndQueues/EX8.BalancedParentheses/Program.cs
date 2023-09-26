namespace EX8.BalancedParentheses
{
    internal class Program
    {
        static void Main()
        {
            string input;
            bool checkValid = false;
            while ((input = Console.ReadLine()) != "end")
            {
                if (string.IsNullOrEmpty(input) || (input[0] != '{' && input[0] != '[' && input[0] != '('))
                {
                    break;
                }
                Stack<char> check = new Stack<char>();
                foreach (var item in input)
                {
                    if (item == '[' || item == '(' || item == '{')
                    {
                    check.Push(item);
                    }
                    else if (item == ']' || item == ')' || item == '}')
                    {

                        if (check.Count == 0)
                        {
                            checkValid = false;
                            break;
                        }

                        char top = check.Pop();

                        if ((top == '[' && item == ']') || (top == '(' && item == ')') || (top == '{' && item == '}'))
                        {
                            checkValid = true;
                        }
                        else
                        {
                            checkValid = false;
                            break;
                        }
                    }
                }
                if (check.Count > 0)
                {
                    checkValid = false;
                }
                if (checkValid)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}