namespace L2.SumMatrixColumns
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
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = input2[col];
                }
            }
            for (int col1 = 0; col1 < colsCount; col1++)
            {
                int sum = 0;
                for (int row1 = 0; row1 < rowsCount; row1++)
                {
                    sum += matrix[row1, col1];
                }
                Console.WriteLine(sum);
            }
        }

    }
}