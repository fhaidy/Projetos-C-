using System;
using System.Globalization;
using ExcPropostoException.Entities;
using ExcPropostoException.Entities.Exceptions;
namespace ExcPropostoException {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, initialBalance, withdrawLimit);


                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(amount);

                Console.Write("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }catch(DomainException e) {
                Console.WriteLine("Withdraw error: " + e.Message);
            }catch(FormatException e) {
                Console.WriteLine("Format error: " + e.Message);
            }
        }
    }
}
