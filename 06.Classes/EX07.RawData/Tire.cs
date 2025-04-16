using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07.RawData
{
    public class Tire
    {
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private float pressure;
        public float Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public Tire(int year, float pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
