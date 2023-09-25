namespace EX7.TruckTour
{
    internal class Program
    {
        static void Main()
        {
            Queue<int[]> pumps = new Queue<int[]>();
            int pumpsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < pumpsCount; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                pumps.Enqueue(input);
            }
            int bestRoute = 0;
            while (true)
            {
                int totalFuel = 0;
                foreach (var pump in pumps)
                {
                    totalFuel += pump[0];
                    if (totalFuel - pump[1] < 0)
                    {
                        totalFuel = 0;
                        break;
                    }
                    else
                    {
                        totalFuel -= pump[1];
                    }
                }
                if (totalFuel > 0)
                {
                    break;
                }
                bestRoute++;
                pumps.Enqueue(pumps.Dequeue());

            }
            Console.WriteLine(bestRoute);
        }
    }
}