using System;
using System.Data;

namespace Groene_opdracht_Dierenpark
{
    class Program
    {
        static void Main(string[] args)
        {
            {


                double AantalKinderbijslag1, Kinderbijslag2, Aantalkinderen, intSom;

                Console.WriteLine("Hier kunt u uw van Kinderbijslag berekenen. Voor elk kind jonger dan 12 jaar, bedraagt kinderbijslag 150 euro per kwartaal." +
                    "Voor elk kind tussen 12- en 18 jaar bedraagt kinderbijslag 235 euro per kwartaal.");

                Console.WriteLine("Hier kunt u uw leeftijd van uw kinderen berekenen");
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
                    Console.WriteLine("U kunt alleen: '1', '2' of '3' opgeven, omdat anders dit systeem niet werkt.");
                }

                Console.WriteLine("Per kind jonger dan 12 jaar, bedraagt kinderbijslag 150 euro. ");
                    Console.Write("Typ het aantal kinderen dat u heeft van onder 12 jaar: ");
                    AantalKinderbijslag1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Per kind tussen 12- en 18 jaar jaar, bedraagt kinderbijslag 235 euro. ");
                    Console.Write("Typ het aantal kinderen dat u heeft van tussen 12- en 18 jaar: ");
                    Kinderbijslag2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Hoeveel kinderen heeft u in totaal? ");
                    Aantalkinderen = Convert.ToInt32(Console.ReadLine());

                    if (Aantalkinderen < 3)
                    {
                        intSom = (AantalKinderbijslag1 * 150) + (Kinderbijslag2 * 235);

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Het totaal bedrag dat u krijgt in kinderbijslag per kwartaal is: " + intSom.ToString());
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;


                    }

                    else if (Aantalkinderen == 3 || Aantalkinderen == 4)
                    {
                        intSom = (AantalKinderbijslag1 * 150) + (Kinderbijslag2 * 235) / 100 * 102;

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Het totaal bedrag dat u krijgt in kinderbijslag per kwartaal is: " + intSom.ToString());
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;


                    }
                    else if (Aantalkinderen == 5)
                    {
                        intSom = (AantalKinderbijslag1 * 150) + (Kinderbijslag2 * 235) / 100 * 103;

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Het totaal bedrag dat u krijgt in kinderbijslag per kwartaal is: " + intSom.ToString());
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if (Aantalkinderen >= 6)
                    {
                        intSom = (AantalKinderbijslag1 * 150) + (Kinderbijslag2 * 235) / 1000 * 1035;

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Het totaal bedrag dat u krijgt in kinderbijslag per kwartaal is: " + intSom.ToString());
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine("U kunt alleen getallen opgeven. Geen letters. ");
                    }
                }

            }
        }
    }
