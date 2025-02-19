namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string inputTires;
            string inputEngines;

            while ((inputTires = Console.ReadLine()) != "No more tires" )
            {
                var eachTire = inputTires
                    .Split();
                int tire1Year = int.Parse(eachTire[0]);
                double tire1Pressure = double.Parse(eachTire[1]);
                int tire2Year = int.Parse(eachTire[2]);
                double tire2Pressure = double.Parse(eachTire[3]);
                int tire3Year = int.Parse(eachTire[4]);
                double tire3Pressure = double.Parse(eachTire[5]);
                int tire4Year = int.Parse(eachTire[6]);
                double tire4Pressure = double.Parse(eachTire[7]);

                var fourTires = new Tire[4]
                {
                    new Tire (tire1Year, tire1Pressure),
                    new Tire (tire2Year, tire2Pressure),
                    new Tire (tire3Year, tire3Pressure),
                    new Tire (tire4Year, tire4Pressure),
                };
                tires.Add(fourTires);
            }

            while ((inputEngines = Console.ReadLine()) != "Engines done")
            {
                var eachEngine = inputEngines
                    .Split()
                    .ToArray();
                int engineHP = int.Parse(eachEngine[0]);
                double engineCapacity = double.Parse(eachEngine[1]);

                Engine engine = new Engine(engineHP, engineCapacity);
                engines.Add(engine);
            }
            string carInput;
            int index = 0;
            while ((carInput = Console.ReadLine()) != "Show special")
            {
                var carInfo = carInput
                    .Split();
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                Engine engine = new Engine(engines[index].HorsePower, engines[index].CubicCapacity);
                Tire[] tire = tires[index];
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tire);
                cars.Add(car);
                index++;
            }

            int drive = 20;
            foreach (var car in cars)
            {
                double totalPressure = car.Tires.Sum(x => x.Pressure);
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && totalPressure >= 9 && totalPressure <= 10)
                {
                    car.Drive(drive);
                    car.WhoAmI();
                }
            }
        }
    }
}