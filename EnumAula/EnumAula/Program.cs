using System;
using EnumAula.Entities;
using EnumAula.Entities.Enums;

namespace EnumAula {
    class Program {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };

            Console.WriteLine(order.ToString());

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>(txt);

            Console.WriteLine(os);

        }
    }
}
