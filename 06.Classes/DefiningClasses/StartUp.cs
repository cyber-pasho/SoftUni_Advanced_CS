using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine()
                    .Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                family.AddPerson(person);
            }

            var sortedFamily = family.SortedFamily();
            foreach (var person in sortedFamily)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}