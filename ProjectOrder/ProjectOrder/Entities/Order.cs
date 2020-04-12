using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using ProjectOrder.Entities.Enums;

namespace ProjectOrder.Entities
{
    class Order
    {
        public DateTime Date { get; private set; }
        public OrderStatus Status { get; private set; }
        public Client client { get; private set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Order()
        {
        }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            this.client = client;
        }

        public void addItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double total()
        {
            double total = 0.0;
            foreach(OrderItem item in Itens)
            {
                total += item.subTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder frase = new StringBuilder();

            frase.AppendLine("ORDER SUMMARY:");
            frase.Append("Order moment: ");
            frase.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            frase.Append("Order status: ");
            frase.AppendLine(Status.ToString());
            frase.Append("Client: ");
            frase.Append(client.Name);
            frase.Append(" (" + client.BirthDate.ToString("dd/MM/yyyy") + ")");
            frase.AppendLine(" - " + client.Email);
            frase.AppendLine("Order items:");
            foreach (OrderItem item in Itens)
            {
                frase.Append(item.Product.Name);
                frase.Append(", R$:" + item.price.ToString("F2",CultureInfo.InvariantCulture));
                frase.Append(", Quantity: " + item.quantity);
                frase.AppendLine(", Subtotal: " + item.subTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            frase.Append("Total price: " + total().ToString("F2", CultureInfo.InvariantCulture));
            return frase.ToString();
        }
    }
}
