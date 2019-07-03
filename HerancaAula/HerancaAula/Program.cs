using HerancaAula.Entities;

namespace HerancaAula {
    class Program {
        static void Main(string[] args) {

            /*Account account = new Account(1001, "Alex", 0.0);

            BussinessAccount bussinessAccount = new BussinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING

            Account account1 = bussinessAccount;

            Account account2 = new BussinessAccount(1003, "Bob", 0.0, 200.00);

            Account account3 = new SavingAccount(1004, "Ana", 0.0, 0.01);

            //Downcasting
            BussinessAccount account4 = (BussinessAccount) account2;

            account4.Loan(100.00);

            if(account3 is BussinessAccount) {
                //BussinessAccount account5 = (BussinessAccount)account3;
                BussinessAccount account5 = account3 as BussinessAccount;

            }

            if (account3 is SavingAccount) {
                //SavingAccount account5 = (SavingAccount)account3;
                BussinessAccount account5 = account3 as SavingAccount;
                account5.UpdateBalance();
                System.Console.WriteLine("Update");
            }*/

            Account account = new Account(1001, "Alex", 500.00);

            Account account1 = new SavingAccount(1002, "Anna", 500.00, 0.01);

            account.Withdraw(10.00);
            account1.Withdraw(10.00);

            System.Console.WriteLine(account.Balance);

            System.Console.WriteLine(account1.Balance);


        }
    }
}
