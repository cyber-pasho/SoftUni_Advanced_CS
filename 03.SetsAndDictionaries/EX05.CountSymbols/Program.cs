namespace EX05.CountSymbols
{
    internal class Program
    {
        static void Main()
        {
            SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();
            var input = Console.ReadLine();
            foreach (var item in input)
            {
                if (!charsCount.ContainsKey(item))
                {
                    charsCount.Add(item, 1);
                }
                else
                {
                    charsCount[item]++;
                }
            }
            foreach (var item in charsCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}