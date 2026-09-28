// Ber användaren skriva ett tal och gör om det till ett tal
Console.WriteLine("Skriv ett tal");
double number1 = Convert.ToDouble(Console.ReadLine());

// Gör samma sak igen
Console.WriteLine("Skriv ett till tal");
double number2 = Convert.ToDouble(Console.ReadLine());

// Skriver ut svaren
Console.WriteLine($"Addition: {number1 + number2}");
Console.WriteLine($"Subtraktion: {number1 - number2}");
Console.WriteLine($"Multiplikation: {number1 * number2}");

// Gör så att om number2 talet är 0 så skriver den ut text istället för ett ogiltligt tal
// Och om inte 0 så gör som dom andra
if (number2 != 0)
{
    Console.WriteLine($"Division: {number1 / number2}");
}
else
{
    Console.WriteLine("Det går inte att dela med noll!");
}