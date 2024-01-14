using System.Dynamic;

namespace EX9.Miner
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string[,] mine = new string[size, size];
            var movements = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            int minerRow = 0;
            int minerCol = 0;
            int coal = 0;
            for (int row = 0; row < size; row++)
            {
                var matrixInput = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < size; col++)
                {
                    mine[row,col] = matrixInput[col];
                    if (mine[row,col] == "s")
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                }
            }
            foreach (var move in movements)
            {
                if (move == "left")
                {
                    if (minerCol - 1 < 0)
                    {
                        continue;
                    }
                    else
                    {
                        minerCol -= 1;
                        switch (mine[minerRow, minerCol])
                        {
                            case "*":
                                continue;
                            case "c":
                                mine[minerRow, minerCol] = "*";
                                if (!Exists(mine))
                                {
                                    Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                                    return;
                                }
                                continue;
                            case "e":
                                Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                                return;
                        }
                    }
                }
                else if (move == "right")
                {
                    if (minerCol + 1 > mine.GetLength(1)-1)
                    {
                        continue;
                    }
                    else
                    {
                        minerCol += 1;
                        switch (mine[minerRow, minerCol])
                        {
                            case "*":
                                continue;
                            case "c":
                                mine[minerRow, minerCol] = "*";
                                if (!Exists(mine))
                                {
                                    Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                                    return;
                                }
                                continue;
                            case "e":
                                Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                                return;
                        }
                    }
                }
                else if (move == "up")
                {
                    if (minerRow - 1 < 0)
                    {
                        continue;
                    }
                    else
                    {
                        minerRow -= 1;
                        switch (mine[minerRow, minerCol])
                        {
                            case "*":
                                continue;
                            case "c":
                                mine[minerRow, minerCol] = "*";
                                if (!Exists(mine))
                                {
                                    Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                                    return;
                                }
                                continue;
                            case "e":
                                Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                                return;
                        }
                    }
                }
                else if (move == "down")
                {
                    if (minerRow + 1 > mine.GetLength(0)-1)
                    {
                        continue;
                    }
                    else
                    {
                        minerRow += 1;
                        switch (mine[minerRow, minerCol])
                        {
                            case "*":
                                continue;
                            case "c":
                                mine[minerRow, minerCol] = "*";
                                if (!Exists(mine))
                                {
                                    Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                                    return;
                                }
                                continue;
                            case "e":
                                Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                                return;
                        }
                    }
                }
            }
            foreach (var item in mine)
            {
                if (item == "c")
                {
                    coal++;
                }
            }
            Console.WriteLine($"{coal} coals left. ({minerRow}, {minerCol})");
        }
        static bool Exists(string[,] mine)
        {
            bool exists = false;
            for (int row = 0; row < mine.GetLength(0); row++)
            {
                for (int col = 0; col < mine.GetLength(1); col++)
                {
                    if (mine[row,col] == "c")
                    {
                        exists = true;
                        break;
                    }
                }
            }
            return exists;
        }
    }
}