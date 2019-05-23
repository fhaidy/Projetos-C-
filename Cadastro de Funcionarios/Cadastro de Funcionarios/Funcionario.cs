using System.Globalization;

namespace Cadastro_de_Funcionarios {
    class Funcionario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario  { get; set; }

        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagemAumento) {
            Salario += (Salario*porcentagemAumento)/100;
        }

        public override string ToString() {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
