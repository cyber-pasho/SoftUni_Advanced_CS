using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    internal class Parking
    {
        // Fields
        private List<Car> cars;
        private int capacity;

        // Constructor
        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        // Count property
        public int Count => cars.Count;

        // AddCar method
        public string AddCar(Car car)
        {
            if (cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (cars.Count >= capacity)
            {
                return "Parking is full!";
            }

            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        // RemoveCar method
        public string RemoveCar(string registrationNumber)
        {
            Car carToRemove = cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);

            if (carToRemove == null)
            {
                return "Car with that registration number, doesn't exist!";
            }

            cars.Remove(carToRemove);
            return $"Successfully removed {registrationNumber}";
        }

        // GetCar method
        public Car GetCar(string registrationNumber)
        {
            return cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
        }

        // RemoveSetOfRegistrationNumber method
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string regNum in registrationNumbers)
            {
                Car carToRemove = cars.FirstOrDefault(c => c.RegistrationNumber == regNum);
                if (carToRemove != null)
                {
                    cars.Remove(carToRemove);
                }
            }
        }
    }
}
