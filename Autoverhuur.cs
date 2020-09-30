using System;

namespace Autoverhuur
{
    class Program
    {
        static void Main(string[] args)
        {
            double AantalKMAuto, LiterBezine, VrijKM, intSom;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hier wordt berekend wat de u kwijt aan Autoverhuur ");
            Console.WriteLine("Welk type auto wilt u huren? Kies '1' als het om een personenauto gaat of kies'2' als het om een personenbusje gaat: ");
            int TypAuto = Convert.ToInt32(Console.ReadLine());
            if (TypAuto == 1)
            {

                Console.Write("Vanaf welke datum wilt u deze auto huren? (dd/mm/jjjj): ");
                DateTime firstdate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Op welke datum wilt u deze auto inleveren? (dd/mm/jjjj): ");
                DateTime lastdate = Convert.ToDateTime(Console.ReadLine());
                int tijdhuur = lastdate.Day - firstdate.Day;

                if (firstdate > lastdate.AddDays(-tijdhuur))
                    tijdhuur--;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("U wilt een personenauto huren voor " + tijdhuur + " dagen");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hoeveel KM heeft u, of wilt u rijden met uw personenauto?");
                AantalKMAuto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hoeveel liter bezine heeft u gebruikt of wilt u verbruiken in totaal? ");
                LiterBezine = Convert.ToInt32(Console.ReadLine());
                VrijKM = tijdhuur * 100;

                if (AantalKMAuto <= VrijKM)
                {
                    intSom = (LiterBezine / 100 * 135) + (tijdhuur * 50);
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Het totaal te betalen bedrag van huren van auto in EUR is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (AantalKMAuto > VrijKM)
                {
                    intSom = (LiterBezine / 100 * 135) + (AantalKMAuto / 100 * 20) + (tijdhuur * 50);
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Het totaal te betalen bedrag van het huren van auto in EUR is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (TypAuto == 2)
            {
                Console.Write("Vanaf welke datum wilt u deze busje huren? (dd/mm/jjjj): ");
                DateTime firstdate = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Op welke datum wilt u deze busje inleveren? (dd/mm/jjjj): ");
                DateTime lastdate = Convert.ToDateTime(Console.ReadLine());
                int tijdhuur = lastdate.Day - firstdate.Day;

                if (firstdate > lastdate.AddDays(-tijdhuur))
                    tijdhuur--;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("U wilt een personenbusje huren voor " + tijdhuur + " dagen");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hoeveel KM heeft u, of wilt u rijden met uw personenbusje?");
                AantalKMAuto = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hoeveel liter bezine heeft u gebruikt of wilt u verbruiken in totaal? ");
                LiterBezine = Convert.ToInt32(Console.ReadLine());
                intSom = (LiterBezine / 100 * 135) + (AantalKMAuto / 100 * 20 - 100) + (tijdhuur * 50);
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Het totaal te betalen bedrag van huren busje in EUR is: " + intSom.ToString());
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Type '1' of '2' in. Geen woorden letters, etc. Alleen '1' of '2' in getallen");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
            }
           
        }
    }
}
