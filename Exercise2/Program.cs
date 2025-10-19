Console.Write("Enter your first name: ");
string firstName = Console.ReadLine().Trim();

Console.Write("Enter your last name: ");
string lastName = Console.ReadLine().Trim();

while (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
{
    Console.WriteLine("Both first name and last name must be provided. Please try again.");

    Console.Write("Enter your first name: ");
    firstName = Console.ReadLine().Trim();

    Console.Write("Enter your last name: ");
    lastName = Console.ReadLine().Trim();
}


Console.WriteLine($"Hello, {firstName} {lastName}!");
