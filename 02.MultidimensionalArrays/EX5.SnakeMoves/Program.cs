namespace EX5.SnakeMoves
{
    internal class Program
    {
        static void Main()
        {
            var matrixDimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[matrixDimensions[0], matrixDimensions[1]];
            var input = Console.ReadLine();
            int counter = 0;
            int rowCounter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (counter == input.Length)
                {
                    counter = 0;
                }
                if (rowCounter % 2 != 0)
                {
                    for (int y = matrix.GetLength(1)-1; y >= 0; y--)
                    {
                        if (counter == input.Length)
                        {
                            counter = 0;
                        }
                        matrix[i, y] = input[counter];
                        counter++;
                    }
                }
                else
                {
                    for (int y = 0; y < matrix.GetLength(1); y++)
                    {
                        if (counter == input.Length)
                        {
                            counter = 0;
                        }
                        matrix[i, y] = input[counter];
                        counter++;
                    }
                }
                rowCounter++;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int x = 0; x < matrix.GetLength(1); x++)
                {
                    Console.Write($"{matrix[i, x]}");
                }
                Console.WriteLine();
            }
        }
    }
}