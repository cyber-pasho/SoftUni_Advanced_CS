//input->
var size = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rowSize = size[0];
int colSize = size[1];
string[,] lair = new string[rowSize, colSize];
bool gameOver = false;
int playerRow = 0;
int playerCol = 0;
//input<-
//matrix initialize->
for (int row = 0; row < rowSize; row++)
{
    var matrixRow = Console.ReadLine()
        .Split("", StringSplitOptions.RemoveEmptyEntries);
    for (int col = 0; col < colSize; col++)
    {
        lair[row, col] = matrixRow[col];
        if (lair[row, col] == "P")
        {
            playerRow = row;
            playerCol = col;
        }
    }
}
//matrix initialize<-
//movement input->
var movement = Console.ReadLine()
    .Split("", StringSplitOptions.RemoveEmptyEntries);
//movement input<-
//task//
while (!gameOver)
{
    for (int round = 0; round > 0; round++)
    {
        if (movement[round] == "R")
        {
            if (playerCol == lair.GetLength(1) - 1)
            {
                gameOver = true;
                Console.WriteLine($"won: {playerRow} {playerCol}");
                break;
            }
            Infection(lair);
            playerCol++;
            if (lair[playerRow, playerCol] == "B")
            {
                gameOver = true;
                Console.WriteLine($"dead: {playerRow} {playerCol}");
                break;
            }
            lair[playerRow, playerCol] = "P";
        }
        else if (movement[round] == "L")
        {

        }
        else if (movement[round] == "U")
        {

        }
        else if (movement[round] == "D")
        {

        }
        else if (round > movement.Length - 1)
        {

        }
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
