using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06.SpeedRacing
{
    internal class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionFor1km;

            TravelledDistance = 0;
        }

        public void Travel(double distance)
        {
            if (FuelConsumptionPerKilometer * distance > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= distance*FuelConsumptionPerKilometer;
                TravelledDistance += distance;
            }
        }

        public void Result()
        {
            Console.WriteLine($"{Model} {FuelAmount:F2} {TravelledDistance}");
        }
    }
}
