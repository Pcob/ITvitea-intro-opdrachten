using System;

namespace Waterverbruik
{
    class Program
    {
        static void Main(string[] args)
        {
            double Prijsartikel, intSom;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hier kunt u de leeftijdskorting berekenen van uw artikel");
            Console.Write("Geef de datum van het artikel weer: (dd/mm/jjjj): ");
            DateTime bday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Today;
            int age1 = today.Year - bday.Year;

            if (bday > today.AddYears(-age1))
                age1--;
            
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Jouw artikel is: " + age1 + " jaar oud");
                Console.ForegroundColor = ConsoleColor.White;
            
                if (age1 >= 2 || age1 < 3)
                {
                    Console.Write("De leeftijdskorting die u krijgt, is 5%. Geef de prijs van het artikel om de prijs van artikel, inclusief korting te bereken: ");
                    Prijsartikel = Convert.ToInt32(Console.ReadLine());
                    intSom = (Prijsartikel / 100 * 95);

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("De totale prijs van het artikel, inclusief korting is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (age1 >= 3 || age1 < 5)
                {
                    Console.Write("De leeftijdskorting die u krijgt, is 10%. Geef de prijs van het artikel om de prijs van artikel, inclusief korting te bereken: ");
                    Prijsartikel = Convert.ToInt32(Console.ReadLine());
                    intSom = (Prijsartikel / 100 * 90);

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("De totale prijs van het artikel, inclusief korting is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (age1 >= 5)
                {
                    Console.Write("De leeftijdskorting die u krijgt, is 25%. Geef de prijs van het artikel om de prijs van artikel, inclusief korting te bereken: ");
                    Prijsartikel = Convert.ToInt32(Console.ReadLine());
                    intSom = (Prijsartikel / 100 * 75);

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("De totale prijs van het artikel, inclusief korting is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: type '0','1' of '2' in.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
        }
    }
}