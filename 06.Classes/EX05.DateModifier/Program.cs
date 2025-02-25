namespace EX05.DateModifier
{
    internal class Program
    {
        static void Main()
        {
            string date1 = string.Empty;
            string date2 = string.Empty;
            for (int i = 0; i <= 1; i++)
            {
                string input = Console.ReadLine();
                if (i == 0)
                {
                    date1 = input;
                }
                else
                {
                    date2 = input;
                }
            }


            DataModifier dates = new DataModifier(date1, date2);

            int difference = dates.DaysDifference();

            Console.WriteLine($"{Math.Abs(difference)}");
        }
    }
}
