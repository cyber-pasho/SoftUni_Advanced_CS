namespace L3.PrimaryDiagonal
{
    internal class Program
    {
        static void Main()
        {
            int numofRows = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numofRows, numofRows];
            for (int i = 0; i < numofRows; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int y = 0; y < input.Length; y++)
                {
                    matrix[i, y] = input[y];
                }
            }
            int diagonalSum = 0;
            for (int row = 0; row < numofRows; row++)
            {
                for (int col = 0; col < numofRows; col++)
                {
                    if (col == row)
                    {
                        diagonalSum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(diagonalSum);
        }
    }
}