using System.ComponentModel.Design;

namespace _6.Supermarket
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> que = new Queue<string>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Paid")
                {
                    que.Enqueue(input);
                }
                else
                {
                    while (que.Count > 0)
                    {
                        string person = que.Dequeue();
                        Console.WriteLine(person);
                    }
                }
            }
            Console.WriteLine($"{que.Count} people remaining.");
        }
    }
}
