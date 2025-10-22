internal class BankAccount
{
    public string AccountNumber;
    private decimal Balance;

    public BankAccount(string accountNumber, decimal balance) { this.AccountNumber = accountNumber; this.Balance = balance;}

    public void Deposit(decimal amount)
    {
        Console.WriteLine($"Пополнить счет на: {amount}");
        Balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Вы сняли {amount}. Текущий баланс {Balance}");
        }
        else
        {
            Console.WriteLine("Недостаточно средств");
        }
    }
    public void PrintBalance()
    {
        Console.WriteLine(Balance);
    }

}
