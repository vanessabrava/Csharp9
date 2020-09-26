using System;

namespace DWC.CSharp9.IsNot
{
    class Program
    {
        static void Main(string[] args)
        {
            var conjunto = new object[] { "Maria", 7, null, "Joao", null, DateTime.Now };

            foreach (object tipo in conjunto)
            {
                if (tipo is not null)
                {
                    if (tipo is not string)
                        Console.WriteLine($"Tipo: {tipo.GetType().FullName} - Valor: {tipo}");
                    else
                        Console.WriteLine($"Objeto string: {tipo}");
                }
                else
                    Console.WriteLine("Objeto nulo");
            }
        }
    }
}
