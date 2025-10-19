Console.Write("How yoou want to see data? (1- day, 2- month, 3- year, 4- hour, 5- minute, 6- second): ");
string choice = Console.ReadLine();
DateTime now = DateTime.Now;
switch (choice)
{
    case "1":
        Console.WriteLine($"Day: {now.Day}");
        break;
    case "2":
        Console.WriteLine($"Month: {now.Month}");
        break;
    case "3":
        Console.WriteLine($"Year: {now.Year}");
        break;
    case "4":
        Console.WriteLine($"Hour: {now.Hour}");
        break;
    case "5":
        Console.WriteLine($"Minute: {now.Minute}");
        break;
    case "6":
        Console.WriteLine($"Second: {now.Second}");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}
Console.ReadLine();
      
