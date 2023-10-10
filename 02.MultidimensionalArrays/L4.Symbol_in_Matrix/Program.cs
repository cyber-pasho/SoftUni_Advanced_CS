namespace L4.Symbol_in_Matrix
{
    internal class Program
    {
        static void Main()
        {
            int matrixDimensions = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixDimensions, matrixDimensions];
            for (int i = 0; i < matrixDimensions; i++)
            {
                var input = Console.ReadLine();
                for (int y = 0; y < input.Length; y++)
                {
                    matrix[i, y] = input[y];
                }
            }
            bool isValid = false;
            char existingChar = char.Parse(Console.ReadLine());
            for (int row = 0; row < matrixDimensions; row++)
            {
                for (int col = 0; col < matrixDimensions; col++)
                {
                    if (matrix[row, col] == existingChar)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isValid = true;
                        break;
                    }
                }
                if (isValid)
                {
                    break;
                }
            }
            if (!isValid)
            {
                Console.WriteLine($"{existingChar} does not occur in the matrix");
            }
        }
    }
}