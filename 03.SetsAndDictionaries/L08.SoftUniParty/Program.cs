namespace L08.SoftUniParty
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> normalGuests = new HashSet<string>();
            HashSet<string> VIPGuests = new HashSet<string>();
            HashSet<string> missingGuests = new HashSet<string>();
            string input;
            bool party = false;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "PARTY" || party)
                {
                    party = true;
                    missingGuests.Remove(input);
                }
                else if (input.Length == 8)
                {
                    if (input[0] >= '0' && input[0] <= '9')
                    {
                        VIPGuests.Add(input);
                        missingGuests.Add(input);
                    }
                    else
                    {
                        normalGuests.Add(input);
                        missingGuests.Add(input);
                    }
                }
            }
            HashSet<string> orderedVIP = new HashSet<string>();
            HashSet<string> orderedNormal = new HashSet<string>();
            foreach (var item in missingGuests)
            {
                if (item[0] >= '0' && item[0] <= '9')
                {
                    orderedVIP.Add(item);
                }
                else
                {
                    orderedNormal.Add(item);
                }
            }
            Console.WriteLine(orderedVIP.Count + orderedNormal.Count);
            foreach (var person in orderedVIP)
            {
                Console.WriteLine(person);
            }
            foreach (var person in orderedNormal)
            {
                Console.WriteLine(person);
            }
        }
    }
}