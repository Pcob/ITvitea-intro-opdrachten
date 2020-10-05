using System;
using System.Runtime.CompilerServices;
using Torens_van_Hanoi;

namespace Torens_van_Hanoi
{
    class TorensHanoi
    {
        int num_dics;
        public TorensHanoi()
        {

            num_dics = 0;

        }
        public TorensHanoi(int newvalue)
        {
            num_dics = newvalue;
        }
        public int dicsnums
        {
            get
            {
                return num_dics;
            }
            set
            {
                if (value > 0)
                    num_dics = value;

            }
        }
        public void movetower(int i, int from, int to, int other)
        {
            if (i > 0)
            {
                movetower(i - 1, from, other, to);
                Console.WriteLine("Verplaats schijf {0} van stokje {1} naar stokje {2}", i, from, to);
                movetower(i - 1, other, to, from);
            }
        }
    }
}
class TowerHanoiApp
{
    public static int Main()
    {
        TorensHanoi t = new TorensHanoi();
        string c_numdisc;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Dit is het spel; Torens van Hanoi op 3 stokjes.");
        Console.WriteLine("Geef het aantal schijven op dat je wilt gebruiken: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Aantal schijven: ");
        c_numdisc = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;
        t.dicsnums = Convert.ToInt32(c_numdisc);
        t.movetower(t.dicsnums, 1, 3, 2);
        Console.ReadLine();
        return 0;

    }
}
