namespace L1.SumMatrixElements
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
            int counterInput = 0;
            List<int> matrixElements = new List<int>();
            while (counterInput != rowsCount)
            {
                var input2 = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                counterInput++;
                foreach ( var element in input2)
                {
                    matrixElements.Add(element);
                }
            }
            int counter = 0;
            for (int row = 0; row < rowsCount; row++)
            {
               for (int col = 0; col < colsCount; col++)
               {
                matrix[row,col] = matrixElements[counter++];
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