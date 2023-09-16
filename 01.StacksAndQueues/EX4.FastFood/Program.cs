
namespace EX4.FastFood
{
    internal class Program
    {
        static void Main()
        {
            int meals = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine(orders.Max());
            bool foodless = false;
            int loop = orders.Count();
            for (int i = 0; i < loop; i++)
            {
                if (meals >= orders.Peek())
                {
                    meals -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    foodless = true;
                    break;
                }
            }
            if (!foodless)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}