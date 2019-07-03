using System;
using System.Collections.Generic;
using System.Text;
using ExercicioPropostoComposicao.Entities.Enums;

namespace ExercicioPropostoComposicao.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client{ get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order() {
        }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddOrderItem(OrderItem item) {
            OrderItems.Add(item);
        }

        public void RemoveOrderItem(OrderItem item) {
            OrderItems.Remove(item);
        }

        public double Total() {
            double sum = 0;
            foreach(OrderItem item in OrderItems) {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order momment: " + Moment);
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToShortDateString() + ") - " + Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItems) {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: " + Total());
            return sb.ToString();
        }
    }
}
