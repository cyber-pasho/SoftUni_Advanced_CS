namespace EX5.FashionBoutique
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int initialClotesCount = clothes.Count();
            int racksCount = 1;
            int capacity = rackCapacity;
            for (int i = 0; i < initialClotesCount; i++)
            {
                if (clothes.Peek() <= capacity)
                {
                    capacity -= clothes.Pop();
                }
                else
                {
                    racksCount++;
                    capacity = rackCapacity - clothes.Pop();
                }
            }
            Console.WriteLine(racksCount);
        }
    }
}