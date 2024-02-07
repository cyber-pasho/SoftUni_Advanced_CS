namespace L06.UniqueNames
{
    internal class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();
            string nameInput;
            for (int i = 0; i < count; i++)
            {
                nameInput = Console.ReadLine();
                uniqueNames.Add(nameInput);
            }
            foreach (string uniqueName in uniqueNames)
            {
                Console.WriteLine(uniqueName);
            }
        }
    }
}