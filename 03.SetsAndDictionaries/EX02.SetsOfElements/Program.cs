namespace EX02.SetsOfElements
{
    internal class Program
    {
        static void Main()
        {
            var size = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int size1 = size[0];
            int size2 = size[1];
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < size1; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list1.Add(input);
            }
            for (int i = 0; i < size2; i++)
            {
                int input = int.Parse(Console.ReadLine());
                list2.Add(input);
            }
            HashSet<int> set = new HashSet<int>();
            foreach (var number in list1)
            {
                if (list2.Contains(number))
                {
                    set.Add(number);
                }
            }
            foreach (var item in set)
            {
                Console.Write($"{item} ");
            }
        }
    }
}