public class BankAccount
{
    // Saldo är privat: det kan inte ändras direkt utanför klassen.
    private decimal balance;

    // En property som används för att läsa och ändra saldot.
    public decimal Balance
    {
        get
        {
            return balance;
        }
        set
        {
            // Spara bara värdet om saldot inte blir negativt.
            if (value >= 0)
            {
                balance = value;
            }
        }
    }
}