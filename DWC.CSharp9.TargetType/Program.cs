using System;

namespace DWC.CSharp9.TargetType
{
    public class Program
    {
        static void Main(string[] args)
        {
            TiranossauroRex tiranossauroRex = null;
            Velociraptor velociraptor = new();
            Dinossauro dinossauro = tiranossauroRex ?? velociraptor;
            Console.WriteLine("");
        }
    }

    public class Dinossauro { }

    public class TiranossauroRex : Dinossauro { }

    public class Velociraptor : Dinossauro { }
}
