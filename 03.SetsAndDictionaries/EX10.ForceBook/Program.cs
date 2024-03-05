using System.Diagnostics.Metrics;
using System.Globalization;

namespace EX10.ForceBook
{
    internal class Program
    {
        static void Main()
        {
            string input;
            string side = string.Empty;
            string member = string.Empty;
            SortedDictionary<string, List<string>> sides = new SortedDictionary<string, List<string>>();
            string[] delimiters = {"|", "->"};
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                var inputs = input
                    .Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
                if (input.Contains("|"))
                {
                    member = inputs[1].Trim();
                    side = inputs[0].Trim();
                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new List<string>() { member });
                    }
                    else
                    {
                        sides[side].Add(member);
                    }
                }
                else if (input.Contains("->"))
                {
                    int counter = 0;
                    string side1 = string.Empty;
                    string side2 = string.Empty;
                    foreach (var item in sides)
                    {
                        if (counter==0)
                        {
                            side1 = item.Key;
                        }    
                        else 
                        { 
                            side2 = item.Key;
                        }
                        counter++;
                    }
                    member = inputs[0].Trim();
                    side = inputs[1].Trim();
                    if (!sides[side1].Contains(member) && !sides[side2].Contains(member))
                    {
                        sides[side].Add(member);
                        Console.WriteLine($"{member} joins the {side} side!");
                    }
                    else
                    {
                        if (side1 == side && !sides[side].Contains(member))
                        {
                            sides[side1].Add(member);
                            sides[side2].Remove(member);
                            Console.WriteLine($"{member} joins the {side} side!");
                        }
                        else if (side2 == side && !sides[side].Contains(member))
                        {
                            sides[side2].Add(member);
                            sides[side1].Remove(member);
                            Console.WriteLine($"{member} joins the {side} side!");
                        }
                    }
                }
            }
            var sortedDictionary = sides
                    .OrderBy(x=>x.Value.Count);
            foreach (var group in sides)
            {
                if (group.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {group.Key}, Members: {group.Value.Count}");
                    foreach (var x in group.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {x}");
                    }
                }
            }
        }
    }
}
