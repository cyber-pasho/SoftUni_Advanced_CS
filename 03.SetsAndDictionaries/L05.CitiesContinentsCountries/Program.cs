namespace L05.CitiesContinentsCountries
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> output = new Dictionary<string, Dictionary<string, List<string>>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!output.ContainsKey(continent))
                {
                    output.Add(continent, new Dictionary<string, List<string>>()
                    {
                        {
                            country, new List<string>()
                            { city }
                        }
                    });
                }
                else
                {
                    foreach (var item in output)
                    {
                        if (item.Key == continent)
                        {
                            if (!item.Value.ContainsKey(country))
                            {
                                item.Value.Add(country, new List<string>()
                                {
                                    city

                                }
                                );
                                break;
                            }
                            else
                            {
                                foreach (var y in item.Value)
                                {
                                    if (y.Key == country && !y.Value.Contains(city))
                                    {
                                        y.Value.Add(city);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            foreach (var q in output)
            {
                Console.WriteLine($"{q.Key}:");
                foreach (var w in q.Value)
                {
                    Console.Write($"  {w.Key} -> ");
                    Console.Write(string.Join(", ", w.Value));
                    Console.WriteLine();
                }
            }
        }
    }
}