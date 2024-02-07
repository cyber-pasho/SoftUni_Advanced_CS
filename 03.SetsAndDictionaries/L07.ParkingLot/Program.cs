namespace L07.ParkingLot
{
    internal class Program
    {
        static void Main()
        {
            string input;
            HashSet<string> parking = new HashSet<string>();
            while ((input = Console.ReadLine()) != "END")
            {
                var car = input.
                    Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = car[0];
                string plateNumber = car[1];
                switch (direction)
                {
                    case "IN":
                        parking.Add(plateNumber);
                        continue;
                    case "OUT":
                        parking.Remove(plateNumber);
                        continue;
                }
            }
            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}