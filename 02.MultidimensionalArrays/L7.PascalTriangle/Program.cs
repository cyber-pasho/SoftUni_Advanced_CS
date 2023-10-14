namespace L7.PascalTriangle
{
    internal class Program
    {
        static void Main()
        {
            int rows = Convert.ToInt32(Console.ReadLine());

            long[][] pascalsTriangle = new long[rows][];

            for (int i = 0; i < rows; i++)
            {
                pascalsTriangle[i] = new long[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        pascalsTriangle[i][j] = 1;
                    }
                    else
                    {
                        pascalsTriangle[i][j] = pascalsTriangle[i - 1][j - 1] + pascalsTriangle[i - 1][j];
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(pascalsTriangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}