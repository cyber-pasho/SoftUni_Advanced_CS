namespace EX07.TheV_Logger
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Vlogger> vloggers = new Dictionary<string, Vlogger>();
            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                var data = input
                    .Split(" ");
                string name = data[0];
                string command = data[1];
                string recipient = data[2];
                switch (command)
                {
                    case "joined":
                        if (!vloggers.ContainsKey(name))
                        {
                            Vlogger vlogger = new Vlogger(name, new HashSet<string>(), new HashSet<string>());
                            vloggers.Add(name, vlogger);
                        }
                        continue;
                    case "followed":
                        if (vloggers.ContainsKey(recipient) && vloggers.ContainsKey(name))
                        {
                            foreach (var vlogger in vloggers)
                            {
                                if (vlogger.Key == recipient)
                                {
                                    vlogger.Value.Followers.Add(name);
                                }
                            }
                        }
                        continue;
                }
            }
        }
        public class Vlogger
        {
            public Vlogger(string name, HashSet<string> followers, HashSet<string> following)
            {
                Name = name;
                Followers = followers;
                Following = following;
            }

            public string Name { get; set; }
            public HashSet<string> Followers { get; set; }
            public HashSet<string> Following { get; set; }

        }
    }
}