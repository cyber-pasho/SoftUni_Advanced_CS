namespace EX06.SpeedRacing
{
    internal class Program
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            string input = string.Empty;

            int carCount = int.Parse(Console.ReadLine());

            while ((input = Console.ReadLine()) != "End")
            {
                var carInput = input
                    .Split(" ")
                    .ToArray();

                string model = carInput[0];
                string fuelAmount = carInput[1];
                double fuelConsumption = double.Parse(carInput[2]);

                if (model == "Drive")
                {
                    foreach (var car in cars)
                    {
                        if (car.Model == fuelAmount)
                        {
                            car.Travel(fuelConsumption);
                        }
                    }
                        
                }
                else
                {
                    Car car = new Car(model, double.Parse(fuelAmount), fuelConsumption);
                    cars.Add(car);
                }
            }
            foreach (var car in cars)
            {
                car.Result();
            }
        }
    }
}
