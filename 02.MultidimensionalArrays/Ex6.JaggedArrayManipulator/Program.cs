namespace Ex6.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            int inputRows = int.Parse(Console.ReadLine());
            string input;
            int[][] matrix = new int[inputRows][];
            //
            while ((input = Console.ReadLine()) != "End")
            {
                //asign-->
                for (int i = 0; i < inputRows; i++)
                {
                    var inputLines = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    matrix[i] = new int[inputLines.Length];
                    for (int z = 0; z < inputLines.Length; z++)
                    {
                        matrix[i][z] = inputLines[z];
                    }
                    input = Console.ReadLine();
                }
                //asign<--
                //analyze-->
                for (int j = 1; j < inputRows; j++)
                {
                    if (matrix[j].Length == matrix[j-1].Length)
                    {
                        for (int y = j-1; y <= j; y++)
                        {
                            for (int k = 0; k < matrix[y].Length; k++)
                            {
                                matrix[y][k] *= 2;
                            }
                        }
                    }
                    else
                    {
                        for (int q = j - 1; q <= j; q++)
                        {
                            for (int w = 0; w < matrix[q].Length; w++)
                            {
                                matrix[q][w] /= 2;
                            }
                        }
                    }
                }
                //analyze--<
            }
        }
    }
}