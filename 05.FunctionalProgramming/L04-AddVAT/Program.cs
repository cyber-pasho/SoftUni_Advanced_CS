namespace L04_AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .ToArray();
            //
            Func<double, double> addedVAT = num => num * 1.2;
            //
            foreach (var number in prices)
            {
                var numberWithVAT = addedVAT(number);
                Console.WriteLine($"{Math.Round(numberWithVAT,2):f2}");
            }
        }
    }
}
