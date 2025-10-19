Console.Write("Insert a word: ");
string word1 = Console.ReadLine();
string wordWithoutSpaces = word1.Replace(" ", "");

if (word1.Length == 0)
{
    Console.WriteLine("You did not enter a word.");
    return;
}

int length1 = wordWithoutSpaces.Length;
int length2 = word1.Length;

Console.WriteLine($"The length of the word without spaces is {length1}.");
Console.WriteLine($"The length of the word with spaces is {length2}.");

Console.ReadLine();

