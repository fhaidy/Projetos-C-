namespace HerancaAula.Entities {
    class SavingAccount : Account {

        public double InterestRate { get; set; }

        public SavingAccount() { }

        public SavingAccount(int number, string holder, double balance, double interestRate) :base (number, holder, balance) {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += InterestRate * Balance;
        }

        public override void Withdraw(double amount) {
            Balance -= amount;
        }


    }
}
