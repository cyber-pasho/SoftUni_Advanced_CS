using System.Dynamic;

namespace EX8.Bombs
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            var bombs = Console.ReadLine()
                .Split(" ")
                .ToArray();
            int aliveCounter = 0;
            int aliveSum = 0;
            foreach (var bomb in bombs)
            {
                var coords = bomb
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int bombRow = coords[0];
                int bombCol = coords[1];
                Explode(bombRow, bombCol, matrix);
            }
            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    aliveCounter++;
                    aliveSum += item;
                }
            }
            Console.WriteLine($"Alive cells: {aliveCounter}");
            Console.WriteLine($"Sum: {aliveSum}");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Explode(int bombRow, int bombCol, int[,] matrix)
        {
            int damage = matrix[bombRow, bombCol];
            if (damage > 0)
            {
                matrix[bombRow, bombCol] = 0;
                //top
                if (bombRow > 0 && matrix[bombRow - 1, bombCol] > 0)
                {
                    matrix[bombRow - 1, bombCol] -= damage;
                }
                //bottom
                if (bombRow < matrix.GetLength(0) - 1 && matrix[bombRow + 1, bombCol] > 0)
                {
                    matrix[bombRow + 1, bombCol] -= damage;
                }
                //left
                if (bombCol > 0 && matrix[bombRow, bombCol - 1] > 0)
                {
                    matrix[bombRow, bombCol - 1] -= damage;
                }
                //right
                if (bombCol < matrix.GetLength(1) - 1 && matrix[bombRow, bombCol + 1] > 0)
                {
                    matrix[bombRow, bombCol + 1] -= damage;
                }
                //top left
                if (bombRow > 0 && bombCol > 0 && matrix[bombRow - 1, bombCol - 1] > 0)
                {
                    matrix[bombRow - 1, bombCol - 1] -= damage;
                }
                //bottom left
                if (bombRow < matrix.GetLength(0) - 1 && bombCol > 0 && matrix[bombRow + 1, bombCol - 1] > 0)
                {
                    matrix[bombRow + 1, bombCol - 1] -= damage;
                }

                //top right
                if (bombRow > 0 && bombCol < matrix.GetLength(1) - 1 && matrix[bombRow - 1, bombCol + 1] > 0)
                {
                    matrix[bombRow - 1, bombCol + 1] -= damage;
                }

                //bottom right
                if (bombRow < matrix.GetLength(0) - 1 && bombCol < matrix.GetLength(1) - 1 && matrix[bombRow + 1, bombCol + 1] > 0)
                {
                    matrix[bombRow + 1, bombCol + 1] -= damage;
                }
            }
        }
    }
}