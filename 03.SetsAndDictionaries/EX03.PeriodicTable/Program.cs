namespace EX03.PeriodicTable
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> elements = new HashSet<string>();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ");
                foreach (var element in input)
                {
                    elements.Add(element);
                }
            }
            List<string> sortedElements = new List<string>(elements)
                .OrderBy(x => x)
                .ToList();
            Console.WriteLine(string.Join(" ",sortedElements));
        }
    }
}