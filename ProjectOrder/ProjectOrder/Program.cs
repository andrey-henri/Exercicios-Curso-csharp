using System;
using System.Collections.Generic;
using System.Globalization;
using ProjectOrder.Entities;
using ProjectOrder.Entities.Enums;

namespace ProjectOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Client ct = new Client(name, email, birth);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, ct);

            Console.Write("How many items to this order? ");
            int qtdProd = int.Parse(Console.ReadLine());
            for(int i = 1; i <= qtdProd; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string Nameproduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product prod = new Product(Nameproduct, price);
                OrderItem orderItem = new OrderItem(quantity, price, prod);
                order.addItem(orderItem);
            }
            Console.WriteLine("\n" + order);
        }
    }
}
