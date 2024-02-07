namespace EX06.Wardrobe
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string,int>> wardrobe = new Dictionary<string, Dictionary<string,int>>();
            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine()
                    .Split(" -> ");
                string color = input[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                var clothes = input[1]
                    .Split(",");
                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 1);
                    }
                    else
                    {
                        wardrobe[color][item]++;
                    }
                }
            }
            var search = Console.ReadLine()
                .Split(" ");
            string searchColor = search[0];
            string searchItem = search[1];
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key == searchColor && item.Key == searchItem)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }

                }
            }
        }
    }
}