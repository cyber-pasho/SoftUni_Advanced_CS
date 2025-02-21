using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public List<Person> People { get; set; }


        public void AddPerson(Person person)
        {
            People.Add(person);
        }

        public List<Person> SortedFamily()
        {
            var sortedFamily = People
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList();

            return sortedFamily;
        }
    }
}
