using System;
using System.Collections.Generic;
using System.Text.Json;

namespace DWC.CSharp9.OnlyProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var humano = new Humano()
            {
                Nome = "Vanessa"
            };

            var humano2 = new Humano("Bela");
            
            Humano huma = new(“Dora”);

            List<Humano> humanos = new { huma };
            foreach (Humano humano in humanos)
                Console.WriteLine(JsonSerializer.Serialize(humano));


            Console.WriteLine(JsonSerializer.Serialize(humano));
            Console.WriteLine(JsonSerializer.Serialize(humano2));
        }
    }

    public class Humano
    {
        public string Nome { get; init; }

        public Humano() { }

        public Humano(string nome)
        {
            Nome = nome;
        }
    }
}
