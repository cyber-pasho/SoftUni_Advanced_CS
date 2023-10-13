namespace L5.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main()
        {
            //7, 1, 3, 3, 2, 1
            //1, 3, 9, 8, 5, 6
            //4, 6, 7, 9, 1, 0

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
            List<int[,]> innerMatrix = new List<int[,]>();
            for (int x = 0; x < rowsCount - 1; x++)
            {
                for (int y = 0; y < colsCount - 1; y++)
                {
                    int[,] matrixInput =
                    {
                        {matrix[x,y], matrix[x,y+1]},
                        {matrix[x+1,y], matrix[x+1,y+1]}
                    };
                    innerMatrix.Add(matrixInput);
                }
            }
            int sum = 0;
            int validMatrix = 0;
            for (int i = 0; i < innerMatrix.Count; i++)
            {
                int sum1 = innerMatrix[i].Cast<int>().Sum();
                if (sum1 > sum)
                {
                    sum = sum1;
                    validMatrix = i;
                }
            }
            for (int z = 0; z < innerMatrix[validMatrix].GetLength(0); z++)
            {
                for (int v = 0; v < innerMatrix[validMatrix].GetLength(1); v++)
                {
                    Console.Write($"{innerMatrix[validMatrix][z,v]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{sum}");
        }
    }
}
