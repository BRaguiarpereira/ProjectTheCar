using System;
using System.Globalization;
using ProjectOfTheCar.Entities;
namespace ProjectOfTheCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite  rental data");
            Console.WriteLine("Car model");
            string model = Console.ReadLine();
            Console.WriteLine("Digite a data de retirada (dd/MM/YYYY hh:mm) ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a data de retorno (dd/MM/YYYY hh:mm) ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

        }
    }
}
