namespace EX08_ListofPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 1; i <= range; i++)
            {
                list.Add(i);
            }
            var dividers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Predicate<int> combinedPredicate = num => true;
            foreach (var divider in dividers)
            {
                combinedPredicate = CombinePredicates(combinedPredicate, num => num % divider == 0);
            }
            List<int> filteredNumbers = FilterCollection(list, combinedPredicate);

            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
        private static List<int> FilterCollection(List<int> collection, Predicate<int> predicate)
        {
            return collection.FindAll(predicate);
        }
        private static Predicate<int> CombinePredicates(Predicate<int> predicate1, Predicate<int> predicate2)
        {
            return num => predicate1(num) && predicate2(num);
        }
    }
}
