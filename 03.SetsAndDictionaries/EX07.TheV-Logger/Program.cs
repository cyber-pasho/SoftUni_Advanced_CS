using static EX07.TheV_Logger.Program;

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
                        if (vloggers.TryGetValue(recipient, out Vlogger followed) && vloggers.TryGetValue(name, out Vlogger follower) && vloggers.TryGetValue(name, out Vlogger him) && name != recipient)
                        {
                            followed.Followers.Add(name);
                            follower.Following.Add(recipient);
                        }
                        continue;
                }
            }
            var sortedVloggers = vloggers.Values
                .OrderByDescending(v => v.Followers.Count)
                .ThenBy(v => v.Following.Count)
                .ToList();
            Console.WriteLine($"The V-Logger has a total of {sortedVloggers.Count} vloggers in its logs.");
            int counter = 1;
            foreach (var vlogger in sortedVloggers)
            {
                Console.WriteLine($"{counter}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");
                if (counter == 1)
                {
                    var sortedFollowers = vlogger.Followers
                        .ToList()
                        .OrderBy(v => v)
                        .ToList();
                    foreach (var item in sortedFollowers)
                    {
                        Console.WriteLine($"*  {item}");
                    }
                }
                counter++;
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