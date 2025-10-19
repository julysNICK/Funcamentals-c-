using System.Text.RegularExpressions;

Console.Write("Insert your number vehicle plate(XXX9999 or XXX9X99): ");
string plate = Console.ReadLine();

Console.WriteLine($"The vehicle plate is: {plate}");



bool IsOldBrazilPlate(string plate)
{
         return Regex.IsMatch(plate, @"^[A-Za-z]{3}\d{4}$") 
        || Regex.IsMatch(plate, @"^[A-Za-z]{3}\d[A-Za-z]\d{2}$");
}

if (plate == null || plate.Length != 7)
{
    Console.WriteLine("Invalid plate: must have exactly 7 characters.");
}
else
{
    plate = (plate ?? string.Empty).Trim().Replace("-", "").ToUpperInvariant();
      if (IsOldBrazilPlate(plate))
        {
            Console.WriteLine("Valid plate.");
        }
        else
        {
            Console.WriteLine("Invalid plate: must have 3 letters followed by 4 numbers (e.g., ABC1234).");
        }

        Console.ReadLine();

}
Console.ReadLine();