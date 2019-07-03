using System;
using System.Globalization;
using ExercicioPropostoComposicao.Entities;
using ExercicioPropostoComposicao.Entities.Enums;
namespace ExercicioPropostoComposicao {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/AAAA): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            

            Console.WriteLine("Enter order data:");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);


            Console.Write("How many items for this order? ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++) {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                OrderItem item = new OrderItem(quantity, product);

                order.AddOrderItem(item);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine();
            Console.WriteLine(order.ToString());
        }
    }
}
