namespace EX3.MaximalSum
{
    internal class Program
    {
        static void Main()
        {
            var matrixDimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[matrixDimensions[0], matrixDimensions[1]];
            for (int i = 0; i < matrixDimensions[0]; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int y = 0; y < input.Length; y++)
                {
                    matrix[i, y] = input[y];
                }
            }
            // solution-->
            List<int[,]> variants = new List<int[,]>();
            for (int row = 0; row < matrixDimensions[0] - 2; row++)
            {
                for (int col = 0; col < matrixDimensions[1] - 2; col++)
                {
                    int[,] innerMatrix = new int[3, 3];
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            innerMatrix[i, j] = matrix[row + i, col + j];
                        }
                    }
                    variants.Add(innerMatrix);
                }
            }
            int sum = 0;
            int index = 0;
            int innerIndex = -1;
            foreach (var element in variants)
            {
                int innerSum = 0;
                for(int row = 0; row < element.GetLength(0); row++)
                {
                    for (int col = 0; col < element.GetLength(1); col++)
                    {
                        innerSum += element[row,col];
                    }
                }
                innerIndex++;
                if (innerSum > sum)
                {
                    sum = innerSum;
                    index = innerIndex;
                }
            }
            Console.WriteLine($"Sum = {sum}");
            for (int i = 0; i < variants[index].GetLength(0); i++)
            {
                for (int y = 0; y < variants[index].GetLength(1); y++)
                {
                    Console.Write($"{variants[index][i,y]} ");
                }
                Console.WriteLine();
            }
        }
    }
}