using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07.RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
        int tire1Year, float tire1Pressure,
        int tire2Year, float tire2Pressure,
        int tire3Year, float tire3Pressure,
        int tire4Year, float tire4Pressure)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoType, cargoWeight);
            Tires = new Tire[4]
            {
            new Tire(tire1Year, tire1Pressure),
            new Tire(tire2Year, tire2Pressure),
            new Tire(tire3Year, tire3Pressure),
            new Tire(tire4Year, tire4Pressure)
            };
        }
    }
}
