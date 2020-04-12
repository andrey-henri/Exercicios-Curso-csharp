using System;
using System.Globalization;
using System.Collections.Generic;
using ProjectProduct.Entities;

namespace ProjectProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();

            Console.Write("Enter the number of products: ");
            int quantite = int.Parse(Console.ReadLine());
            for(int i = 1; i <= quantite; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char tgTipo = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(tgTipo == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFree = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add(new ImportedProduct(name, price, customsFree));
                }
                else if(tgTipo == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, manufacture));
                }
                else
                {
                    product.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach(Product prod in product)
            {
                Console.WriteLine(prod.priceTag());
            }      
        }
    }
}
