// See https://aka.ms/new-console-template for more information
using Task2.TaxCalculator;

double salary = double.MinValue;
bool isSalaryValid;

//Will continue asking for salary until user gives a valid number
do
{
    Console.Write("Input salary: ");
    string? salaryInput = Console.ReadLine();
    isSalaryValid = double.TryParse(salaryInput, out salary);
} while (!isSalaryValid || salary < 0);


//Using an interface for better abstraction in case we have different taxcalculators in the future
ITaxCalculator taxCalculator = new TaxCalculator(salary);
Console.WriteLine($"Net salary is: {taxCalculator.CalculateTax()} IDR");
