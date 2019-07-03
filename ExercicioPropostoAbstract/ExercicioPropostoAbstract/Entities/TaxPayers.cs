namespace ExercicioPropostoAbstract.Entities {
    abstract class TaxPayers {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayers() {
        }

        protected TaxPayers(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();

    }
}
