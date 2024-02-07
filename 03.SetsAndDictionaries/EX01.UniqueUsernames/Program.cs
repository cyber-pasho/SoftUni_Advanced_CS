namespace EX01.UniqueUsernames
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                usernames.Add(input);
            }
            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}