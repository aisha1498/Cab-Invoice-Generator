using Cab_Invoice_Generator;

Console.WriteLine("Welcome to Cab Invoice Generator");
InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
double fare = invoiceGenerator.CalculateFare(2.0, 5);
Console.WriteLine($"Fare : {fare}");
Console.ReadLine();// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");