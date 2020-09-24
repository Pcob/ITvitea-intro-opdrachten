using System;
using System.Data;

namespace Groene_opdracht_Dierenpark
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Abonnementsprijs van Dierenpark Emmen berekenen: ");
;               Console.Write("Geef je gebortedatum in (dd/mm/jjjj): ");
                DateTime bday = Convert.ToDateTime(Console.ReadLine());
                DateTime today = DateTime.Today;
                int age = today.Year - bday.Year;

                if (bday > today.AddYears(-age))
                    age--;

                Console.WriteLine("Your age is: " + age);


                int AmountEcht, AmountGezin1, AmountGezin2, AmountPersoon, AmountKind, AmountEcht65, AmountPer65, intSom;

                Console.WriteLine("Prijs van Echtpaar is 61 EUR: ");
                Console.Write("Type het aantal Echtpaar in: ");
                AmountEcht = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Prijs van gezin met 1 kind is 71 EUR: ");
                Console.Write("Type het aantal gezin met 1 kind in: ");
                AmountGezin1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Prijs van gezin met 2 kinderen is 82 EUR: ");
                Console.Write("Type het aantal gezinnen met 2 kinderen in: ");
                AmountGezin2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Prijs persoonlijk is 30 EUR: ");
                Console.Write("Type het aantal personen in: ");
                AmountPersoon = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Prijs van elk kind extra is 11 EUR: ");
                Console.Write("Type het aantal extra kinderen in: ");
                AmountKind = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Prijs van echtpaar 65 plus = 65 EUR: ");
                Console.Write("Type het aantal echtparen 65 plus in: ");
                AmountEcht65 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Prijs persoonlijk 65 plus = 26 EUR ");
                Console.Write("Type het aantal personen 65 plus in: ");
                AmountPer65 = Convert.ToInt32(Console.ReadLine());




                intSom = (AmountEcht * 61) + (AmountGezin1 * 71) + (AmountGezin2 * 82) + (AmountPersoon * 30) + (AmountKind * 11) + (AmountEcht65 * 65) + (AmountPer65 * 26);

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Het totaal te betalen bedrag in EUR is: " + intSom.ToString());
                Console.ReadKey();



            }
        }
    }
}
