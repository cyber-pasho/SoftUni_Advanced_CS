namespace EX07.RawData
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();

                string model = parts[0];
                int engineSpeed = int.Parse(parts[1]);
                int enginePower = int.Parse(parts[2]);
                int cargoWeight = int.Parse(parts[3]);
                string cargoType = parts[4];

                // Tires (year and pressure)
                int tire1Year = int.Parse(parts[6]);
                float tire1Pressure = float.Parse(parts[5]);
                int tire2Year = int.Parse(parts[8]);
                float tire2Pressure = float.Parse(parts[7]);
                int tire3Year = int.Parse(parts[10]);
                float tire3Pressure = float.Parse(parts[9]);
                int tire4Year = int.Parse(parts[12]);
                float tire4Pressure = float.Parse(parts[11]);

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
                    tire1Year, tire1Pressure,
                    tire2Year, tire2Pressure,
                    tire3Year, tire3Pressure,
                    tire4Year, tire4Pressure);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flammable")
            {
                foreach (var car in cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}