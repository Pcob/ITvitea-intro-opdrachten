using System;

namespace Letterfrequenties
{
    class CountCharsWordsLines
    {

    
    
        static void Main() 
        {
            int numWords=0, numChars=0, numLines=0;
            char[] delimiter = { ' ' };
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hier kun je zien/berekenen hoeveel tekens, woorden en zinnen je tekst bevat.");
            Console.WriteLine("Dit doe je door een stuk tekst te typen, of tekst van een document hierin te plakken");
            Console.WriteLine("Type of plak het stuk tekst hieronder, waarvan je het aantal woorden, zinnen en tekens wilt laten tellen. ");
            Console.WriteLine("Klik vervolgens 2 keer op 'Enter'.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool allBlank=false;
            do
            {
                String[] words = Console.ReadLine().Split(delimiter);
                numLines++;
                allBlank = true;
                foreach (String word in words)
                {
                    numChars+=word.Length;
                    if (word.Length > 0) { numWords++; allBlank = false; }
                }
            } while (!allBlank);
            numLines--;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Deze tekst heeft " + numChars + " tekens (spaties niet meegerekend), "
                + numWords + " woorden en " + numLines + " zinnen.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
