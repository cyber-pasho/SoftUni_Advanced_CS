//input->
var size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rowSize = size[0];
int colSize = size[1];
string[,] lair = new string[rowSize, colSize];
bool gameOver = false;
bool gameWin = false;
int playerRow = 0;
int playerCol = 0;
//input<-
//matrix initialize->
for (int row = 0; row < rowSize; row++)
{
    string matrixRow = Console.ReadLine();
    for (int col = 0; col < colSize; col++)
    {
        lair[row, col] = matrixRow[col].ToString();
        if (lair[row, col] == "P")
        {
            playerRow = row;
            playerCol = col;
        }
    }
}
//matrix initialize<-
//movement input->
var movement = Console.ReadLine();
//movement input<-
//task//
while (gameOver==false && gameWin==false)
{
    for (int round = 0; round < int.MaxValue ; round++)
    {
        if (round > movement.Length - 1)
        {
            Infection(lair);
            if (lair[playerRow, playerCol] == "B")
            {
                gameOver = true;
                break;
            }
        }
        else if (movement[round] + "" == "R")
        {
            if (playerCol == lair.GetLength(1) - 1)
            {
                gameWin = true;
                Infection(lair);
                lair[playerRow, playerCol] = ".";
                break;
            }
            playerCol++;
            Infection(lair);
            if (lair[playerRow, playerCol] == "B")
            {
                gameOver = true;
                break;
            }
            lair[playerRow, playerCol] = "P";
            lair[playerRow, playerCol-1] = ".";
        }
        else if (movement[round] + "" == "L")
        {
            if (playerCol == 0)
            {
                gameWin = true;
                Infection(lair);
                lair[playerRow, playerCol] = ".";
                break;
            }
            playerCol--;
            Infection(lair);
            if (lair[playerRow, playerCol] == "B")
            {
                gameOver = true;
                break;
            }
            lair[playerRow, playerCol] = "P";
            lair[playerRow, playerCol + 1] = ".";
        }
        else if (movement[round] + "" == "U")
        {
            if (playerRow == 0)
            {
                gameWin = true;
                Infection(lair);
                lair[playerRow, playerCol] = ".";
                break;
            }
            playerRow--;
            Infection(lair);
            if (lair[playerRow, playerCol] == "B")
            {
                gameOver = true;
                break;
            }
            lair[playerRow, playerCol] = "P";
            lair[playerRow+1, playerCol] = ".";
        }
        else if (movement[round] + "" == "D")
        {
            if (playerRow == lair.GetLength(0)-1)
            {
                gameWin = true;
                Infection(lair);
                lair[playerRow, playerCol] = ".";
                break;
            }
            playerRow++;
            Infection(lair);
            if (lair[playerRow, playerCol] == "B")
            {
                gameOver = true;
                break;
            }
            lair[playerRow, playerCol] = "P";
            lair[playerRow - 1, playerCol] = ".";
        }
        else
        {
            Console.WriteLine("Wrong input");
            return;
        }
    }
    for (int row = 0; row < lair.GetLength(0); row++)
    {
        for (int col = 0; col < lair.GetLength(1); col++)
        {
            Console.Write(lair[row,col]);
        }
        Console.WriteLine();
    }
    if (gameOver)
    {
        Console.WriteLine($"dead: {playerRow} {playerCol}");
    }
    else if (gameWin)
    {
        Console.WriteLine($"won: {playerRow} {playerCol}");
    }
}
static void Infection(string[,] array)
{
    List<Tuple<int, int>> initialBElements = new List<Tuple<int, int>>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == "B")
            {
                initialBElements.Add(Tuple.Create(i, j));
            }
        }
    }
    foreach (var element in initialBElements)
    {
        int i = element.Item1;
        int j = element.Item2;
        if (j - 1 >= 0)
            array[i, j - 1] = "B";
        if (j + 1 < array.GetLength(1))
            array[i, j + 1] = "B";
        if (i - 1 >= 0)
            array[i - 1, j] = "B";
        if (i + 1 < array.GetLength(0))
            array[i + 1, j] = "B";
    }
}
