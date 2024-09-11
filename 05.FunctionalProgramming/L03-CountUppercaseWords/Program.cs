Func<string, bool> wordUppercase = word => !string.IsNullOrEmpty(word) && char.IsUpper(word[0]);
var input = Console.ReadLine()
    .Split(" ")
    .ToArray();
//
foreach (var word in input)
{
    if (wordUppercase(word))
    {
        Console.WriteLine(word);
    }
}
