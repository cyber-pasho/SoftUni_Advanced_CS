namespace L02.AvarageStudentGrades
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine()
                    .Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>() { grade });
                }
                else
                {
                    students[name].Add(grade);
                }
            }
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(value => $"{value:F2}"))} (avg: {item.Value.Average():F2})");
            }
        }
    }
}