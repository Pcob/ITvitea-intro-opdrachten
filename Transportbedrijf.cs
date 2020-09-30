using System;

namespace Autoverhuur
{
    class Program
    {
        static void Main(string[] args)
        {
            double VolumeComponent, GewichtComponent, AantalKM, AantalKMBedrag, AantalKMBuitenland, intSom;
           
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hier kunt de kosten van transport berekenen ");
            Console.WriteLine("Geef aan of u een vloeibare lading heeft. Kies '1' als je GEEN vloeibare lading hebt of kies '2' als je WEL vloeibare ladingen hebt");
            int TypAuto = Convert.ToInt32(Console.ReadLine());
            if (TypAuto == 1)
            {

                Console.WriteLine("Hoe groot is het Volume-component dat u verhuurd in kubieke meter?");
                VolumeComponent = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hoe groot is het gewicht-component dat u vervoerd in kilogram?");
                GewichtComponent = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hoeveel kilometers heeft u gereden of bent u van plan te rijden binnen Nederland?");
                AantalKM = Convert.ToInt32(Console.ReadLine());
               
                AantalKMBedrag = (VolumeComponent / 100 * 80) + (GewichtComponent / 100 * 55);

                Console.WriteLine("Rijdt u ook in het buitenland of bent u dit van plan te doen? Type 'Ja' of 'Nee'.");
                string buitenland = Console.ReadLine();

                if (buitenland == "Nee")
                {
                    intSom = AantalKM * AantalKMBedrag;
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Het totaal te betalen bedrag voor de transport in EUR is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (buitenland == "Ja")
                {
                    Console.WriteLine("Hoeveel kilometer hebt u buiten Nederland gereden of bent u van plan dat te doen?");
                    AantalKMBuitenland = Convert.ToInt32(Console.ReadLine());
                    intSom = (AantalKM * AantalKMBedrag) + (AantalKMBuitenland * AantalKMBedrag / 100 * 145) + (AantalKMBedrag / 1000 * 1035 + 45);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Het totaal te betalen bedrag voor de transport in EUR is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Type 'Ja' of 'Nee'. Let op dat je geen hoofdletters vergeet");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else if (TypAuto == 2)
            {
                Console.WriteLine("Hoe groot is het Volume-component dat u verhuurd in kubieke meter?");
                VolumeComponent = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hoe groot is het gewicht-component dat u vervoerd in kilogram?");
                GewichtComponent = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hoeveel kilometers heeft u gereden of bent u van plan te rijden binnen Nederland?");
                AantalKM = Convert.ToInt32(Console.ReadLine());

                AantalKMBedrag = (VolumeComponent / 100 * 125) + (GewichtComponent / 100 * 45);

                Console.WriteLine("Rijdt u ook in het buitenland of bent u dit van plan te doen? Type 'Ja' of 'Nee'.");
                string buitenland = Console.ReadLine();

                if (buitenland == "Nee")
                {
                    intSom = AantalKM * AantalKMBedrag;
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Het totaal te betalen bedrag voor de transport in EUR is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (buitenland == "Ja")
                {
                    Console.WriteLine("Hoeveel kilometer hebt u buiten Nederland gereden of bent u van plan dat te doen?");
                    AantalKMBuitenland = Convert.ToInt32(Console.ReadLine());
                    intSom = (AantalKM * AantalKMBedrag) + (AantalKMBuitenland * AantalKMBedrag / 100 * 145) + (AantalKMBedrag / 1000 * 1035 + 45);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Het totaal te betalen bedrag voor de transport in EUR is: " + intSom.ToString());
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Type 'Ja' of 'Nee'. Let op dat je geen hoofdletters vergeet");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
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
