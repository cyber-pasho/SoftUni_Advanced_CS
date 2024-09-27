namespace EX07_PredicateforNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nameLenght = int.Parse(Console.ReadLine());
            var input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var filteredNames = FilterCollection(input, name => name.Length <= nameLenght);
            foreach (var item in filteredNames)
            {
                Console.Write(item);
                Console.WriteLine();
            }
        }
        private static List<string> FilterCollection(List<string> collection, Predicate<string> predicate)
        {
            return collection.FindAll(predicate);
        }
    }
}
