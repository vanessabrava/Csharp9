using System;

namespace DWC.CSharp9.Expressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            public static string IdadeMundo(int ano) =>
              ano switch
              {
                  < -3000 => "Egito Antigo",
                  >= -3000 and < 1453 => "Idade Média",
                  >= 1453 => "Idade Moderna ou Contemporânea"
              };

            static void Main()
            {
                int[] anos = { 236, 1982, 1089, -10000, 2020, 625, -429, 1500, 1810, 1947 };
                foreach (int ano in anos)
                    Console.WriteLine($"{ano} = {IdadeMundo(ano)}");
            }
        }
    }
}
