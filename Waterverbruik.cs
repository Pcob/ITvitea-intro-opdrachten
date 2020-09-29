using System;

namespace Waterverbruik
{
    class Program
    {
        static void Main(string[] args)
        {
            double Tarief, Verbruiksinhoud, verbruik1, intSom;

            Console.WriteLine("Hier wordt uw waterverbruik berekend. Bij tarief 1 betaalt u 100 euro vastrecht per jaar en 0,25 euro per m3 " +
                "bij tarief 2 betaalt u 75 euro vast per jaar en 0,38 euro per m3 ");
            Console.Write("Geef u tarief op. Type '1' als uw tarief 1 gebruikt. Type '2' als u tarief 2 gebruikt. Type '0' als u aan de hand van u waterverbuik wilt kijken welk tarief het voordeligst is:  ");
            Tarief = Convert.ToInt32(Console.ReadLine());
        
            if(Tarief == 1)
            {
                Console.Write("Hoeveel water heeft u verbruikt per kubieke meter? ");
                Verbruiksinhoud = Convert.ToInt32(Console.ReadLine());
                intSom = (100 + (Verbruiksinhoud / 100 * 25));

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Het totale bedrag in EUR dat uw moet betalen aan waterverbuik is: " + intSom.ToString());
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Tarief == 2)
            {
                Console.Write("Hoeveel water heeft u verbruikt per kubieke meter? ");
                Verbruiksinhoud = Convert.ToInt32(Console.ReadLine());
                intSom = (75 + (Verbruiksinhoud / 100 * 38));

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Het totale bedrag in EUR dat uw moet betalen aan waterverbuik is: " + intSom.ToString());
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Tarief == 0)
            {
                Console.Write("Hoeveel water heeft u verbruikt per kubieke meter? ");
                verbruik1 = Convert.ToInt32(Console.ReadLine());
                if (verbruik1 <= 192)
                {
                    intSom = (75 + (verbruik1 / 100 * 38));

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Tarief 2 is het meest voordelig voor u. Het totale bedrag in EUR dat uw moet betalen aan waterverbuik is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (verbruik1 > 192)
                {
                    intSom = (100 + (verbruik1 / 100 * 25));

                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Tarief 1 is het meest voordelig voor u. Het totale bedrag in EUR dat uw moet betalen aan waterverbuik is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
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
