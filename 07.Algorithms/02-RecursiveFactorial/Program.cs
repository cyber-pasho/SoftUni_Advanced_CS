static long Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }

    return n*Factorial(n-1);
}

int input = int.Parse(Console.ReadLine());
Console.WriteLine(Factorial(input));