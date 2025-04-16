namespace EX08.CarSalesman
{
    public class Program
    {
        public static void Main()
        {
            int engineCount = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

            // Reading engine data
            for (int i = 0; i < engineCount; i++)
            {
                string[] engineData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = engineData[0];
                int power = int.Parse(engineData[1]);

                Engine engine = new Engine(model, power);

                if (engineData.Length == 3)
                {
                    if (int.TryParse(engineData[2], out int displacement))
                        engine.EngineDisplacement = displacement;
                    else
                        engine.EngineEfficiency = engineData[2];
                }
                else if (engineData.Length == 4)
                {
                    engine.EngineDisplacement = int.Parse(engineData[2]);
                    engine.EngineEfficiency = engineData[3];
                }

                engines[model] = engine;
            }

            int carCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            // Reading car data
            for (int i = 0; i < carCount; i++)
            {
                string[] carData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carModel = carData[0];
                string engineModel = carData[1];

                Engine engine = engines[engineModel];
                Car car = new Car(carModel, engine);

                if (carData.Length == 3)
                {
                    if (int.TryParse(carData[2], out int weight))
                        car.CarWeight = weight;
                    else
                        car.CarColor = carData[2];
                }
                else if (carData.Length == 4)
                {
                    car.CarWeight = int.Parse(carData[2]);
                    car.CarColor = carData[3];
                }

                cars.Add(car);
            }

            // Output
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.CarModel}:");
                Console.WriteLine($"  {car.CarEngine.EngineModel}:");
                Console.WriteLine($"    Power: {car.CarEngine.EnginePower}");
                Console.WriteLine($"    Displacement: {(car.CarEngine.EngineDisplacement.HasValue ? car.CarEngine.EngineDisplacement.ToString() : "n/a")}");
                Console.WriteLine($"    Efficiency: {(car.CarEngine.EngineEfficiency ?? "n/a")}");
                Console.WriteLine($"  Weight: {(car.CarWeight.HasValue ? car.CarWeight.ToString() : "n/a")}");
                Console.WriteLine($"  Color: {(car.CarColor ?? "n/a")}");
            }
        }
    }
}
