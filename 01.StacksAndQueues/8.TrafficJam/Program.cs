namespace _8.TrafficJam
{
    internal class Program
    {
        static void Main()
        {
            int passingCars = int.Parse(Console.ReadLine());
            string input;
            int carsPassed = 0;
            Queue<string> queue = new Queue<string>();
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 1; i <= passingCars; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        carsPassed++;
                    }
                }
                if (input == "green")
                {
                    continue;
                }
                queue.Enqueue(input);

            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}