namespace EX6.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine()
                .Split(", ")
                .ToArray();
            Queue<string> songsQueue = new Queue<string>();
            foreach (var item in songs)
            {
                songsQueue.Enqueue(item);
            }
            while (songsQueue.Count != 0)
            {
                var input = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                if (input[0] == "Add")
                {
                    List<string> song = new List<string>();
                    for (int i = 1; i < input.Length; i++)
                    {
                        song.Add(input[i]);
                    }
                    if (!songsQueue.Contains(string.Join(" ", song)))
                    {
                        songsQueue.Enqueue(string.Join(" ", song));
                    }
                    else
                    {
                        Console.WriteLine($"{string.Join(" ", song)} is already contained!");
                    }
                }
                else if (input[0] == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (input[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}