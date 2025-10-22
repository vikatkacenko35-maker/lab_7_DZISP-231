using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Book book = new Book();
            book.Title = "Война и мир";
            book.Author = "Толстой";
            book.Year = 1980;
            book.IsAvailable = true;
            book.PrintIfo();
            Book book1 = new Book();
            book1.IsAvailable = false;
            book1.PrintIfo();

            //2
            BankAccount bankAccount = new("money", 0);
            bankAccount.Deposit(1000);
            bankAccount.Withdraw(500);
            bankAccount.PrintBalance();
            //3
            Car car = new("Tesla Model S", 300);
            car.Accelerate(120);
            car.Brake();
            //4
            Dice dice = new Dice();
            dice.Roll();
            dice.Roll();
            dice.Roll();
            Dice dice1 = new Dice(12);
            dice1.Roll();
            dice1.Roll();
            dice1.Roll();
            //5
            Character voin = new(100, 10);
            Character mag = new(50, 100);
            Character strelok = new(70, 70);

        }
    }
}