using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
	public class Car
	{
		private string make;

		public string Make
		{
			get { return make; }
			set { make = value; }
		}

		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}

		private double fuelQuantity;

		public double FuelQuantity
		{
			get { return fuelQuantity; }
			set { fuelQuantity = value; }
		}

		private double fuelConsumption;

		public double FuelConsumption
		{
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}


		public void Drive(int drive)
		{
			double remainingFuel = FuelQuantity - (fuelConsumption * drive);
			if (remainingFuel > 0)
			{
				fuelQuantity = remainingFuel;
			}
			else
			{
				Console.WriteLine("Not enough fuel to perform this trip!");
            }

		}
		public void WhoAmI()
		{
				Console.WriteLine($"Make: {Make}");
				Console.WriteLine($"Make: {Model}");
				Console.WriteLine($"Make: {Year}");
				Console.WriteLine($"Make: {FuelQuantity:F2}");
        }
	}
}
