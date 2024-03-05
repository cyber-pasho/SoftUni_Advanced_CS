namespace EX09.SoftUniExamResults
{
    internal class Program
    {
        static void Main()
        {
            string input;
            Dictionary<string, int> contests = new Dictionary<string, int>();
            Dictionary<string, int> students = new Dictionary<string, int>();
            string name=string.Empty;
            string language =string.Empty;
            string banned = string.Empty;
            int points = 0;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                var inputs = input
                    .Split("-");
                name = inputs[0];
                if (inputs.Length > 2)
                {
                    language = inputs[1];
                    points = int.Parse(inputs[2]);
                }
                else
                {
                    banned = inputs[1];
                }
                if (inputs[1] == "banned")
                {
                    students.Remove(name);
                }
                else
                {
                    if (!contests.ContainsKey(language))
                    {
                        contests.Add(language, 1);

                    }
                    else
                    {
                        contests[language]++;
                    }
                    if (!students.ContainsKey(name))
                    {
                        students.Add(name, points);
                    }
                    else
                    {
                        if (students[name] < points)
                        {
                            students[name] = points;
                        }
                    }
                }
            }
            var sortedContests = contests
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);
            var sortedStudents = students
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);
            Console.WriteLine("Results:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var contest in sortedContests)
            {
                Console.WriteLine($"{contest.Key} - {contest.Value}");
            }
        }
    }
}