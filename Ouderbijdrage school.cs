using System;
using System.Data;
using System.Globalization;
using System.Threading;

namespace Groene_opdracht_Dierenpark
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Hier wordt berekend wat de ouderbijdrage op school moet zijn. Eerst moet de geboortedatums opgegeven van uw kinderen: ");
                Console.Write("Type aantal kinderen dat u heeft in: ");
                int aantalK = Convert.ToInt32(Console.ReadLine());
                if (aantalK == 1)
                {
                    Console.Write("Geef je gebortedatum in van kind 1 (dd/mm/jjjj): ");
                    DateTime bday = Convert.ToDateTime(Console.ReadLine());
                    DateTime today = DateTime.Today;
                    int age1 = today.Year - bday.Year;

                    if (bday > today.AddYears(-age1))
                        age1--;

                    Console.WriteLine("Leeftijd kind 1 is: " + age1);
                }
                else if (aantalK == 2)
                {
                    Console.Write("Geef je gebortedatum in van kind 1 (dd/mm/jjjj): ");
                    DateTime bday = Convert.ToDateTime(Console.ReadLine());
                    DateTime today = DateTime.Today;
                    int age1 = today.Year - bday.Year;

                    if (bday > today.AddYears(-age1))
                        age1--;

                    Console.WriteLine("Leeftijd kind 1 is: " + age1);

                    Console.Write("Geef je gebortedatum in van kind 2 (dd/mm/jjjj): ");
                    DateTime bday2 = Convert.ToDateTime(Console.ReadLine());
                    DateTime today2 = DateTime.Today;
                    int age2 = today2.Year - bday2.Year;

                    if (bday2 > today2.AddYears(-age2))
                        age2--;

                    Console.WriteLine("Leeftijd kind 2 is: " + age2);
                }
                else if (aantalK == 3)
                {
                    Console.Write("Voer uw gebortedatum in van kind 1 (dd/mm/jjjj): ");
                    DateTime bday = Convert.ToDateTime(Console.ReadLine());
                    DateTime today = DateTime.Today;
                    int age1 = today.Year - bday.Year;

                    if (bday > today.AddYears(-age1))
                        age1--;

                    Console.WriteLine("Leeftijd kind 1 is: " + age1);

                    Console.Write("Voer uw gebortedatum in van kind 2 (dd/mm/jjjj): ");
                    DateTime bday2 = Convert.ToDateTime(Console.ReadLine());
                    DateTime today2 = DateTime.Today;
                    int age2 = today2.Year - bday2.Year;

                    if (bday2 > today2.AddYears(-age2))
                        age2--;

                    Console.WriteLine("Leeftijd kind 2 is: " + age2);

                    Console.Write("Voer uw gebortedatum in van kind 3 (dd/mm/jjjj): ");
                    DateTime bday3 = Convert.ToDateTime(Console.ReadLine());
                    DateTime today3 = DateTime.Today;
                    int age3 = today3.Year - bday3.Year;

                    if (bday3 > today3.AddYears(-age3))
                        age3--;

                    Console.WriteLine("Leeftijd kind 3 is: " + age3);

                }
                else
                {
                    Console.WriteLine("U kunt alleen: '1', '2' of '3' opgeven. Voor de ouderbijdrage geld een maximum van 3 kinderen ");
                }


                int Kind10Min, Kind10Plus, AlleenOuder, intSom;

                Console.WriteLine("Het basisbedrag van ouderbijdrage is 50 EUR. Voor elk kind jonger dan 10 jaar, betaal je 25 EUR." +
                    "Voor elk kind van 10 jaar en ouder betaal je 37 EUR. ");
                Console.WriteLine("Prijs van kind jonger dan 10 jaar is 25 EUR: ");
                Console.Write("Type het aantal kinderen dat u heeft van jonger dan 10 jaar in: ");
                Kind10Min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Prijs van kind ouder dan 10 jaar is 37 EUR: ");
                Console.Write("Type het aantal kinderen dat u heeft die ouder dan 10 jaar zijn: ");
                Kind10Plus = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bent u een alleenstaande ouder?");
                Console.Write("Type '1' voor Ja of type '2' voor Nee in: ");
                AlleenOuder = Convert.ToInt32(Console.ReadLine());

                if (AlleenOuder == 1)
                {
                    intSom = (Kind10Min * 25) + (Kind10Plus * 37) / 100 * 75;

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Het totaal te betalen bedrag in EUR is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (AlleenOuder == 2)
                {
                    intSom = (Kind10Min * 25) + (Kind10Plus * 37);

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Het totaal te betalen bedrag in EUR is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                    Console.WriteLine("U moet het getal '1' of '2' in typen. " +
                        "'1' betekent dat u een alleenstaande ouder bent en dus 25 procent korting krijgt." +
                        "'2' betekent dat u geen alleenstaande bent en dus geen korting van 25 procent krijgt");
                    Console.ForegroundColor = ConsoleColor.White;
                    
                }


            }
        }
    }
}
