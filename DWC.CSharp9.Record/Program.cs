using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace DWC.CSharp9.Record
{

    public record StarWars
    {
       public string Jedi { get; init; }
       public string Sith { get; init; }

       public StarWars() { }

       public StarWars(string jedi, string sith) => (Jedi, Sith) = (jedi, sith);
    }
    
    public record Resistence : StarWars
    { 
        public string  Rebels { get; init; }   
    }

    public record Republic : StarWars
    { 
        public string Stormtrooper { get; init; }
        
        public Republic (string stormtrooper):base(Stormtrooper) = (stormtrooper);
    }

    public class Program
    {
        private static void ExibirRecord(object starwars) =>
            Console.WriteLine(JsonSerializer.Serialize(starwars));

        static void Main(string[] args)
        {
            Console.WriteLine("Novo Record...");
            var star = new StarWars("Yoda", "Darth Vader");
            ExibirRecord(star);

            Console.WriteLine("Record com construtor");
            var wars = new StarWars()
            {
                Jedi = "Luke",
                Sith = "Darth Sidious",
            
            };
            ExibirRecord(wars);

        
            Console.WriteLine("Records com herança");
            Republic rep = new("Finn");
            ExibirRecord(rep);
         }
        
    }

}
