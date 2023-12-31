﻿namespace EX2.SquaresInMatrix
{
    internal class Program
    {
        static void Main()
        {
            var matrixDimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[matrixDimensions[0], matrixDimensions[1]];
            for (int i = 0; i < matrixDimensions[0]; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int y = 0; y < input.Length; y++)
                {
                    matrix[i, y] = input[y];
                }
            }
            //solution->
            int counter = 0;
            for (int row = 0; row < matrixDimensions[0] - 1; row++)
            {
                for (int col = 0; col < matrixDimensions[1] - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}