// See https://aka.ms/new-console-template for more information
using Task2.TaxCalculator;

Console.Write("Input salary: ");
double salary = double.Parse(Console.ReadLine());

//Using an interface for better abstraction in case we have different taxcalculators in the future
ITaxCalculator taxCalculator = new TaxCalculator(salary);
Console.WriteLine($"Net salary is: {taxCalculator.CalculateTax()}");
