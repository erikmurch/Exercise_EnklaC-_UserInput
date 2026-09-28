using System;

// Visar former användaren kan välja.
Console.WriteLine("Välj form: 1 = cirkel, 2 = rektangel, 3 = kvadrat");
string choice = Console.ReadLine()!;

// Den här variabeln ska innehålla den form användaren väljer.
Shape form;

if (choice == "1")
{
    // Läser in radien och skapar en cirkel.
    Console.Write("Ange radie: ");
    double radie = Convert.ToDouble(Console.ReadLine());

    form = new Circle(radie);
}
else if (choice == "2")
{
    // Läser in två mått och skapar en rektangel.
    Console.Write("Ange bredd: ");
    double bredd = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ange höjd: ");
    double höjd = Convert.ToDouble(Console.ReadLine());

    form = new Rectangle(bredd, höjd);
}
else if (choice == "3")
{
    // Läser in sidans längd och skapar en kvadrat.
    Console.Write("Ange sidans längd: ");
    double sida = Convert.ToDouble(Console.ReadLine());

    form = new Square(sida);
}
else
{
    // Avslutar om användaren inte valde 1, 2 eller 3.
    Console.WriteLine("Ogiltigt val.");
    return;
}

// Använder den valda formens metod och skriv ut arean.
Console.WriteLine($"Arean är {form.CalculateArea()}");