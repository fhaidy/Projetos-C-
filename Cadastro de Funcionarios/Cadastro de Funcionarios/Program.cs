using System;
using System.Globalization;
using System.Collections.Generic;

namespace Cadastro_de_Funcionarios {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos  funcionários serão registrados?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < n; i++) {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                if (funcionarios.FindIndex(x => x.Id == id) == -1) { 
                    funcionarios.Add(new Funcionario(id, nome, salario));
                } else {
                    Console.WriteLine("O id {0} já foi cadastrado. Informe o próximo funcionário.", id);
                    Console.WriteLine();
                }
            }

            Console.Write("Informe o id do funcionário que receberá um aumento: ");
            int idFuncionario = int.Parse(Console.ReadLine());
            if (funcionarios.FindIndex(x => x.Id == idFuncionario) != -1) {
                Console.Write("Digite a porcentagem do aumento: ");
                double porcentagemAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Funcionario funcionarioAumento = funcionarios.Find(x => x.Id == idFuncionario);

                funcionarioAumento.AumentarSalario(porcentagemAumento);


            } else {
                Console.WriteLine("Este Id não existe");
                Console.WriteLine();
            }

            Console.WriteLine("Lista de fucionário atualizada: ");
            foreach (Funcionario funcionario in funcionarios) {
                Console.WriteLine(funcionario.ToString());
            }

        }
    }
}
