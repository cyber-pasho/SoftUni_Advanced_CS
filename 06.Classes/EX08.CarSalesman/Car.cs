using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08.CarSalesman
{
    internal class Car
    {
        public Car(string carModel,Engine carEngine)
        {
            CarModel = carModel;
            CarEngine = carEngine;
        }

        public string CarModel { get; set; }
        public Engine CarEngine { get; set; }
        public int? CarWeight { get; set; }
        public string CarColor { get; set; }
    }
}
