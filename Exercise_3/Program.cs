//  Ber använaren skriva en fråga och tar in det
Console.WriteLine("Skriv en fråga");
string question = Console.ReadLine();

// Anger olika typer av svar
string[] answer =
{
    "Det finns inom dig själv",
    "Det kan bara gud svara på",
    "Så smart är inte jag"
};

//Anger C# egna random funktion
Random random = new Random();

// Skriver ut funktionen, säger att den ska ta ifrån ett av alternativen ovan
// och skriva ut svaret plus en random från svaren
int number = random.Next(answer.Length);
Console.WriteLine(answer[number]);