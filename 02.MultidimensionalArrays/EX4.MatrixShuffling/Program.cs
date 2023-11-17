namespace EX4.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixDimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[matrixDimensions[0], matrixDimensions[1]];
            for (int i = 0; i < matrixDimensions[0]; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int y = 0; y < input.Length; y++)
                {
                    matrix[i, y] = input[y];
                }
            }
            //solution--->
            string statement;
            while ((statement = Console.ReadLine()) != "END")
            {
                var command = statement
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "swap")
                {
                    //deeper--->
                    if (command.Length != 5)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    string commandValid = command[0];
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);

                    if (row1 >= 0 && row1 < matrixDimensions[0] 
                     && row2 >= 0 && row2 < matrixDimensions[0]
                     && col1 >= 0 && col1 < matrixDimensions[1]
                     && col2 >= 0 && col2 < matrixDimensions[1])

                    {
                        string swapEntry1 = matrix[row1, col1];
                        string swapEntry2 = matrix[row2, col2];
                        matrix[row2, col2] = swapEntry1;
                        matrix[row1, col1] = swapEntry2;
                        //print--->
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int x = 0; x < matrix.GetLength(1); x++)
                            {
                                Console.Write($"{matrix[i,x]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}