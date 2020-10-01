using System;

namespace RomanNumerals
{
    class Program
    {
        
        static Rule[] Rules = new Rule[]
        {
            new Rule(1000, "M"),
            new Rule(900, "CM"),
            new Rule(500, "D"),
            new Rule(400, "CD"),
            new Rule(100, "C"),
            new Rule(90, "XC"),
            new Rule(50, "L"),
            new Rule(40, "XL"),
            new Rule(10, "X"),
            new Rule(9, "IX"),
            new Rule(5, "V"),
            new Rule(4, "IV"),
            new Rule(1, "I"),
        };

        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Type hier een decimaal getal in:");
                int n;
                if (Int32.TryParse(Console.ReadLine(), out n) && n > 0)
                    Console.WriteLine("{0} in romeinse cijfers is:\t {1}", n, Romanise(n));

                else
                    Console.WriteLine("Dit is geen decimaal getal.");
            }
        }

        private static string Romanise(int n)
        {
            if (n == 0) return ""; 

            foreach (var rule in Rules) 
                if (rule.N <= n)
                    return rule.Symbol + Romanise(n - rule.N);  

            
            throw new ArgumentOutOfRangeException("n must be greater than or equal to 0");
        }

       
        class Rule
        {
            public int N { get; set; }
            public string Symbol { get; set; }
            public Rule(int n, string symbol)
            {
                N = n;
                Symbol = symbol;
            }
        }
    }
}