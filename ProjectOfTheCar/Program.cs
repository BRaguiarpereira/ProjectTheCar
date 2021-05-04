using System;
using System.Globalization;
using ProjectOfTheCar.Entities;
using ProjectOfTheCar.Service;
namespace ProjectOfTheCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite  rental data");
            Console.Write("Car model");
            string model = Console.ReadLine();
            Console.Write("Digite a data de retirada (dd/MM/YYYY hh:mm) ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Digite a data de retorno (dd/MM/YYYY hh:mm) ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Price per hour :");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Price per day :");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
