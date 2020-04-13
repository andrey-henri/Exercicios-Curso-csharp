using System;
using System.Collections.Generic;
using System.Globalization;
using ProjectEmployee.Entities;

namespace ProjectEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxpayer = new List<TaxPayer>();
            int id = 0, option = -1;
            double totalTax;

            do
            {
                Console.WriteLine("\n\n Choose an option from the menu: "
                                 + "\n 1 - Register new contributor"
                                 + "\n 2 - Search for a contributor"
                                 + "\n 3 - Print already registered contributors"
                                 + "\n 4 - Calculate taxes for a taxpayer"
                                 + "\n 5 - Calculate total taxes"
                                 + "\n 6 - Perform exercise routine do course de C#"
                                 + "\n 9 - Exit the program\n\n");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        Console.Write("Enter the number of tax payers: ");
                        int number = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= number; i++)
                        {
                            Console.WriteLine($"Tax payer #{i} data:");
                            Console.Write("Individual or company (i/c)? ");
                            char tgCompany = char.Parse(Console.ReadLine().ToLower());
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Anual income: ");
                            double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            if (tgCompany == 'i')
                            {
                                Console.Write("Health expenditures: ");
                                double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                taxpayer.Add(new Individual(name, anualIncome, healthExpenditures));
                            }
                            else if (tgCompany == 'c')
                            {
                                Console.Write("Number of employees: ");
                                int numberOfEmployees = int.Parse(Console.ReadLine());
                                taxpayer.Add(new Company(name, anualIncome, numberOfEmployees));
                            }
                            else
                            {
                                Console.WriteLine("Option invalid! - Individual or Company");
                                break;
                            }
                        }
                        break;

                    case 2:
                        Console.Write("enter the id of the taxpayer you wish to consult: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write(taxpayer[id].ToString());
                        break;

                    case 3:
                        foreach (TaxPayer payer in taxpayer)
                        {
                            Console.WriteLine(payer);
                        }
                        break;

                    case 4:
                        Console.Write("enter the id of the taxpayer who wants to check the rate: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("\n" + taxpayer[id].ToString() + "\nTaxe Paid:" + taxpayer[id].tax().ToString("F2", CultureInfo.InvariantCulture));
                        break;
                    case 5:
                        totalTax = 0.0;
                        foreach (TaxPayer payer in taxpayer)
                        {
                            totalTax += payer.tax();
                        }
                        Console.Write("\nTOTAL TAXES:" + totalTax.ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    case 6:
                        Console.Write("Enter the number of tax payers: ");
                        number = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= number; i++)
                        {
                            Console.WriteLine($"Tax payer #{i} data:");
                            Console.Write("Individual or company (i/c)? ");
                            char tgCompany = char.Parse(Console.ReadLine().ToLower());
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Anual income: ");
                            double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            if (tgCompany == 'i')
                            {
                                Console.Write("Health expenditures: ");
                                double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                                taxpayer.Add(new Individual(name, anualIncome, healthExpenditures));
                            }
                            else if (tgCompany == 'c')
                            {
                                Console.Write("Number of employees: ");
                                int numberOfEmployees = int.Parse(Console.ReadLine());
                                taxpayer.Add(new Company(name, anualIncome, numberOfEmployees));
                            }
                            else
                            {
                                Console.WriteLine("Option invalid! - Individual or Company");
                                break;
                            }
                        }

                        Console.WriteLine("\nTAXES PAID:");
                        totalTax = 0.0;
                        foreach (TaxPayer payer in taxpayer)
                        {
                            Console.WriteLine(payer);
                            totalTax += payer.tax();
                        }
                        Console.WriteLine("Total Taxes: " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    case 9:
                        Environment.Exit(0);
                        break;
                }
            } while (option != 9);
        }
    }
}
