using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05.DateModifier
{
    public class DataModifier
    {
		private string firstDate;
		private string secondDate;

        public string FirstDate
        {
            get { return firstDate; }
            set { firstDate = value; }
        }

        public string SecondDate
        {
            get { return secondDate; }
            set { secondDate = value; }
        }


        public DataModifier(string firstDate, string secondDate)
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }

        public int DaysDifference ()
        {
            var start = firstDate
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int year1 = start [0];
            int month1 = start [1];
            int day1 = start [2];
            
            //

            var end = secondDate
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int year2 = end[0];
            int month2 = end[1];
            int day2 = end[2];

            DateTime date1 = new DateTime(year1, month1, day1);
            DateTime date2 = new DateTime(year2, month2, day2);

            // Calculate difference in days
            int daysDifference = (date2 - date1).Days;

            return daysDifference;
        }
    }
}
