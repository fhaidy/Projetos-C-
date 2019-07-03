using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioPropostoHeranca.Entities;

namespace ExercicioPropostoHeranca {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of products: ");
            int count = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i=1; i<= count; i++) {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                

                if(ch == 'c') {
                    products.Add(new Product(name, price));
                }else if(ch == 'u') {
                    Console.Write("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }else if(ch == 'i') {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in products) {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
