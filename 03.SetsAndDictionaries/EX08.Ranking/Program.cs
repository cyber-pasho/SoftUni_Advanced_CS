using System.Collections.Immutable;

namespace EX08.Ranking
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> students = new SortedDictionary<string, Dictionary<string, int>>();
            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                var contestsInput = input
                    .Split(":");
                string contestName = contestsInput[0];
                string contestPassword = contestsInput[1];
                contests.Add(contestName, contestPassword);
            }
            string input1;
            while ((input1 = Console.ReadLine()) != "end of submissions")
            {
                var submissionsInput = input1
                    .Split("=>");
                string applicationContest = submissionsInput[0];
                string applicationPassword = submissionsInput[1];
                string applicationUsername = submissionsInput[2];
                int applicationPoints = int.Parse(submissionsInput[3]);
                if (contests.ContainsKey(applicationContest) && contests[applicationContest] == applicationPassword)
                {
                    if (!students.TryGetValue(applicationUsername, out Dictionary<string, int> contest))
                    {
                        students.Add(applicationUsername, new Dictionary<string, int>());
                        students[applicationUsername].Add(applicationContest, applicationPoints);
                    }
                    else if (students.TryGetValue(applicationUsername, out Dictionary<string, int> c))
                    {
                        if (c.ContainsKey(applicationContest))
                        {
                            if (c[applicationContest] <= applicationPoints)
                            {
                                c[applicationContest] = applicationPoints;
                            }
                        }
                        else
                        {
                            students[applicationUsername].Add(applicationContest, applicationPoints);
                        }
                    }
                }
            }
            var contestantWithMostPoints = students
                .OrderByDescending(student => student.Value.Values.Sum())
                .FirstOrDefault();
            Console.WriteLine($"Best candidate is {contestantWithMostPoints.Key} with total {contestantWithMostPoints.Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in students)
            {
                Console.WriteLine(student.Key);
                var sortedContests = student.Value
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x=>x.Value);
                foreach (var item in sortedContests)
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}