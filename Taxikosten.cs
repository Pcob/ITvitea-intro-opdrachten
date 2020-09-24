using System;

namespace Taxikosten
{
    class Program
    {
        static void Main(string[] args)
        {

            int AantalKM, AantalMinuten, AantalMinutenB, AantalKMW, AantalMinutenW, AantalMinutenBW, intSom;

            Console.WriteLine("Het berekenen van Taxikosten");
            Console.WriteLine("Prijs per gereden KM buiten weekend is 1 EUR: ");
            Console.Write("Type het aantal KM buiten weekend in: ");
            AantalKM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prijs per gereden minuut tussen 08:00 en 18:00 is 0.25: ");
            Console.Write("Type het aantal gereden minuten van deze periode in: ");
            AantalMinuten = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prijs per gereden minuten buiten periode 08:00 en 18:00 is 0.45: ");
            Console.Write("Type het aantal gereden minuten in deze periode in: ");
            AantalMinutenB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prijs per gereden KM in weekend is 1.15 EUR: ");
            Console.Write("Type het aantal KM in weekend in: ");
            AantalKMW = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prijs per gereden minuut tussen 08:00 en 18:00 in weekend is 0.29: ");
            Console.Write("Type het aantal gereden minuten van deze periode in: ");
            AantalMinutenW = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prijs per gereden minuten buiten periode 08:00 en 18:00 in weekend is 0.52: ");
            Console.Write("Type het aantal gereden minuten in deze periode in: ");
            AantalMinutenBW = Convert.ToInt32(Console.ReadLine());
      



            intSom = (AantalKM * 1) + (AantalMinuten / 100 * 25) + (AantalMinutenB / 100 * 45) + (AantalKMW / 100 * 115) + (AantalMinutenW / 100 * 29) + (AantalMinutenBW / 100 * 52);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Het totaal te betalen bedrag in EUR is: " + intSom.ToString());
            Console.ReadKey();
        }
    }
}
