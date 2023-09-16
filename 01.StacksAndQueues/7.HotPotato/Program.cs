namespace _7.HotPotato
{
    internal class Program
    {
        static void Main()
        {
            Queue<string> players = new Queue<string>(Console.ReadLine().Split());
            int rule = int.Parse(Console.ReadLine());
            int potatoCounter = 0;
            while (players.Count > 1)
            {
                potatoCounter++;
                string currentPlayer = players.Dequeue();
                if (potatoCounter % rule == 0)
                {
                    Console.WriteLine($"Removed {currentPlayer}");
                }
                else
                {
                    players.Enqueue(currentPlayer);
                }

            }
            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
