using System;

// Skapar ett nytt bankkonto där Saldot börjar på 0.
BankAccount konto = new BankAccount();

// Frågar användaren om beloppet.
Console.Write("Hur mycket vill du sätta in? ");
decimal insättning = Convert.ToDecimal(Console.ReadLine());

// Kontrollerar att själva insättningen inte är negativ.
if (insättning < 0)
{
    Console.WriteLine("Du kan inte sätta in ett negativt belopp.");
}
else
{
    // Läser det gamla saldot, lägger till beloppet och sparar det nya saldot.
    konto.Balance = konto.Balance + insättning;

    // Visar saldot.
    Console.WriteLine($"Nytt saldo: {konto.Balance} kr");
}