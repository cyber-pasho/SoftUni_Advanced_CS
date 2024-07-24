namespace L01_SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x=>x)
                .ToList();
            Console.WriteLine(String.Join(", ",input));
        }
    }
}
