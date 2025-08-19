namespace _01_RecursiveArraySum
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Sum(input, 0));
            
            static int Sum(int[] array, int index)
            {
                if (index == array.Length - 1)
                {
                    return array[index];
                }

                return array[index] + Sum(array, index+1);
            }
        }
    }
}
