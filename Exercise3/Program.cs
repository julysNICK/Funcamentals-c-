double num1 = 5.5;
double num2 =0;
double sum = num1 + num2;
Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");

double difference = num1 - num2;
Console.WriteLine($"The difference between {num1} and {num2} is {difference}.");

double product = num1 * num2;
Console.WriteLine($"The product of {num1} and {num2} is {product}.");

double notZero = num2 != 0 ? num2 : 1;
double quotient = num1 / notZero;
Console.WriteLine($"The quotient of {num1} and {notZero} is {quotient}.");


double remainder = num1 % notZero;
Console.WriteLine($"The remainder of {num1} divided by {notZero} is {remainder}.");

double mean = (num1 + num2) / 2;
Console.WriteLine($"The mean of {num1} and {num2} is {mean}.");

Console.ReadLine();

