using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioPropostoAbstract.Entities;
namespace ExercicioPropostoAbstract {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of tax payers: ");
            int count = int.Parse(Console.ReadLine());
            List<TaxPayers> list = new List<TaxPayers>();
            for (int i = 1; i <= count; i++) {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if(ch == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenses));
                }else if(ch == 'c') {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();

            Console.WriteLine("TAXES PAID: ");
            double totalTaxes = 0.0;
            foreach (TaxPayers taxPayers in list) {
                Console.WriteLine(taxPayers.Name + " $ " + taxPayers.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += taxPayers.Taxes();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
