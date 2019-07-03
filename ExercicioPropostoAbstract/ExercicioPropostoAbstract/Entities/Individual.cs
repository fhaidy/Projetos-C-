namespace ExercicioPropostoAbstract.Entities {
    class Individual : TaxPayers {
        public double HealthExpenses { get; set; }

        public Individual(string name, double anualIncome, double healthExpenses) :base(name, anualIncome) {
            HealthExpenses = healthExpenses;
        }

        public override double Taxes() {
            if(AnualIncome < 20000.00) {
                return (AnualIncome * 0.15) - (HealthExpenses * 0.50);
            } else {
                return (AnualIncome * 0.25) - (HealthExpenses * 0.50);
            }
        }
    }
}
