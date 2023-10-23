namespace EX1.DiagonalDifference
{
    internal class Program
    {
        static void Main()
        {
            int matrixDimensions = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixDimensions, matrixDimensions];
            for (int row = 0; row < matrixDimensions; row++)
            {
                var input2 = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrixDimensions; col++)
                {
                    matrix[row, col] = input2[col];
                }
            }
            int sum1 = 0, sum2 = 0;
            for (int row1 = 0; row1 < matrixDimensions; row1++)
            {
                for (int col1 = 0; col1 < matrixDimensions; col1++)
                {
                    if (col1 == row1)
                    {
                        sum1 += matrix[row1, col1];
                    }
                    if (col1 == matrixDimensions - 1 - row1)
                    {
                        sum2 += matrix[row1, col1];
                    }
                }
            }
            int difference = sum1 - sum2;
            Console.WriteLine(Math.Abs(difference));
        }
    }
}