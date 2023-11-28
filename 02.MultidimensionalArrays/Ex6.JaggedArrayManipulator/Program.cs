namespace Ex6.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            int inputRows = int.Parse(Console.ReadLine());
            string input;
            long[][] matrix = new long[inputRows][];
            //
            while ((input = Console.ReadLine()) != "End")
            {
                var inputLines = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (inputLines[0] != "Add" && inputLines[0] != "Subtract")
                {
                    //assign -->
                    for (int i = 0; i < inputRows; i++)
                    {
                        matrix[i] = new long[inputLines.Length];
                        for (int z = 0; z < inputLines.Length; z++)
                        {
                            matrix[i][z] = int.Parse(inputLines[z]);
                        }
                        inputLines = Console.ReadLine().Split();
                    }
                    //assign <--
                    //analyze -->
                    for (int j = 1; j < inputRows; j++)
                    {
                        if (matrix[j].Length == matrix[j - 1].Length)
                        {
                            for (int y = j - 1; y <= j; y++)
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
                    if (inputLines[0] == "End")
                    {
                        break;
                    }
                }
                //analyze <--
                //commands -->
                else if (inputLines[0] == "Add"
                    && long.Parse(inputLines[1]) >= 0
                    && long.Parse(inputLines[1]) < inputRows
                    && long.Parse(inputLines[2]) < matrix[int.Parse(inputLines[1])].Length
                    && long.Parse(inputLines[2]) >= 0)
                {
                    matrix[int.Parse(inputLines[1])][int.Parse(inputLines[2])] += long.Parse(inputLines[3]);
                }
                else if (inputLines[0] == "Subtract"
                    && long.Parse(inputLines[1]) >= 0
                    && long.Parse(inputLines[1]) < inputRows
                    && long.Parse(inputLines[2]) < matrix[int.Parse(inputLines[1])].Length
                    && long.Parse(inputLines[2]) >= 0)
                {
                    matrix[int.Parse(inputLines[1])][int.Parse(inputLines[2])] -= long.Parse(inputLines[3]);
                }
             //commands <--
             // print -->
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
            //print <--
        }
    }
}