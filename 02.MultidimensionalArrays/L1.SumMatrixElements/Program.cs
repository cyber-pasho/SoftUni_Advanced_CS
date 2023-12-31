﻿namespace L1.SumMatrixElements
{
    internal class Program
    {
        static void Main()
        {
            var input1 = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rowsCount = input1[0];
            int colsCount = input1[1];
            int[,] matrix = new int[rowsCount, colsCount];
            for (int row = 0; row < rowsCount; row++)
            {
                var input2 = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = input2[col];
                }
            }
            Console.WriteLine(input1[0]);
            Console.WriteLine(input1[1]);
            int sum = 0;
            foreach (var item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}