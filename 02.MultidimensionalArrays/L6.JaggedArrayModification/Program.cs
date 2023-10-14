namespace L6.JaggedArrayModification
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                var inputRows = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                jagged[row] = new int[inputRows.Length];
                for (int col = 0; col < inputRows.Length; col++)
                {
                    jagged[row][col] = inputRows[col];
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var statement = input
                    .Split(" ")
                    .ToArray();
                string command = statement[0];
                int rowCoordinates = int.Parse(statement[1]);
                int colCoordinates = int.Parse(statement[2]);
                int commandValue = int.Parse(statement[3]);
                //
                if (rowCoordinates > rows-1 || rowCoordinates < 0 || colCoordinates < 0 || jagged[rowCoordinates].Length < colCoordinates)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (command == "Add")
                {
                    jagged[rowCoordinates][colCoordinates] += commandValue;
                }
                else
                {
                    jagged[rowCoordinates][colCoordinates] -= commandValue;
                }
            }
            for (int x = 0; x < jagged.GetLength(0); x++)
            {
                for (int y = 0; y < jagged[x].Length; y++)
                {
                    Console.Write($"{jagged[x][y]} ");
                }
                Console.WriteLine();
            }
        }
    }
}