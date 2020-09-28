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

                Console.WriteLine("Hier wordt uw Inkomstenbelasting berekent.");


                    Console.Write("Wat is uw jaarinkomen? ");
                    Inkomen = Convert.ToInt32(Console.ReadLine());
                    if (Inkomen < 8000)
                    {
                        intSom = ((Inkomen - 419)  / 10000 * 3575);

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Het totale bedrag in EUR dat uw aan belasting moet betalen is: " + intSom.ToString());
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                        
                    }
                    else if (Inkomen > 8000 && Inkomen < 25001)
                    { 
                        intSom = ((Inkomen - 419) / 10000 * 3705);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Het totale bedrag in EUR dat uw aan belasting moet betalen is: " + intSom.ToString());
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else if (Inkomen > 25000 && Inkomen < 54001)
                    {
                        intSom = ((Inkomen - 8799) / 10000 * 5000);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Het totale bedrag in EUR dat uw aan belasting moet betalen is: " + intSom.ToString());
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else if (Inkomen > 54001)
                    {
                        intSom = ((Inkomen - 15503) / 10000 * 6000);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Het totale bedrag in EUR dat uw aan belasting moet betalen is: " + intSom.ToString());
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Type het juiste bedrag in. Dit moet zonder euroteken");
                    Console.ForegroundColor = ConsoleColor.White;
                    }

                


            }
        }
    }
}