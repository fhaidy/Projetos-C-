using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoComposicao.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public double Price { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, Product product) {
            Quantity = quantity;
            Product = product;
            Price = product.Price;
        }

        public double SubTotal() {
            return Quantity * Price;
        }

        public override string ToString() {
            return Product.Name + ", " + Price + ", " + Quantity + ", Subtotal: " + SubTotal();
        }
    }
}
