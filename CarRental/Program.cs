using CarRental.Entities;
using System;
using System.Globalization;
using CarRental.Services;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: \n");
            Console.WriteLine("Car Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("\nPick (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("\nReturn (dd/MM/yyyy HH:mm):");
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("\nEnter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\nEnter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Rental rental = new Rental(start, end, new Vehicle(model));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

            rentalService.ProcessInVoice(rental);
            Console.WriteLine("\n\nIN VOICE:\n");
            Console.WriteLine(rental.Invoice);

        }
    }
}
