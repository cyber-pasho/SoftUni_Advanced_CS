namespace L01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> numbers = new Dictionary<double, int>();
            foreach (var number in input)
            {
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 1);
                }
                else 
                { 
                    numbers[number]++; 
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}