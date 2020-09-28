using System;
using System.Data;

namespace Groene_opdracht_Dierenpark
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Double Inkomen, intSom;

                Console.WriteLine("Het berekenen van uw Eenmalige uitkering. Het uitkeringsbedrag is afhankelijk van uw leeftijd");
                Console.Write("Bent u jonger dan 21 jaar en ongehuwed? ");
                String leeftijd = Console.ReadLine();


                if (leeftijd == "Ja")
                {
                    Console.Write("Wat is uw jaarinkomen? ");
                    Inkomen = Convert.ToInt32(Console.ReadLine());
                    if (Inkomen < 15600)
                    {
                        intSom = (Inkomen / 10000 * 175);

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Het totaal uit te keren bedrag in EUR is: " + intSom.ToString());
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                        if(intSom < 250)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Let op! Als de uitkering lager valt dan 250 euro, dan wordt deze opgetrokken naar 250 EURO");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Het jaarinkomensgrens voor een uitkering is 15600. Bij een hoger inkomen, heb je geen recht op uitkering");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else if (leeftijd == "Nee")
                {
                    Console.Write("Wat is uw jaarinkomen? ");
                    Inkomen = Convert.ToInt32(Console.ReadLine());
                    if (Inkomen < 17100)
                    {
                        intSom = (Inkomen / 10000 * 175);

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Het totaal uit te keren bedrag in EUR is: " + intSom.ToString());
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (intSom < 250)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Let op! Als de uitkering lager valt dan 250 euro, dan wordt deze opgetrokken naar 250 EURO");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Het jaarinkomensgrens voor een uitkering is 17100. Bij een hoger inkomen, heb je geen recht op uitkering");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Type 'Ja of 'Nee' in. Let op dat je geen hoofdletters vergeet.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                    
                    
            }
        }
    }
}
