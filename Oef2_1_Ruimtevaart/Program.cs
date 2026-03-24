namespace Oef2_1_Ruimtevaart
{
    // Oefening 2.1 – Ruimtevaart (constructors bij overerving)
    // Pas BemandeRaket.cs aan zodat onderstaande output klopt.
    //
    // Verwachte output:
    //   Raket aangemaakt: Artemis
    //   Bemande raket klaar voor 4 astronauten.
    //   Artemis | Brandstof: 50000L | Crew: 4

    internal class Program
    {
        static void Main(string[] args)
        {
            BemandeRaket br = new BemandeRaket("Artemis", 50000, 4);
            Console.WriteLine($"{br.Naam} | Brandstof: {br.BrandstofCapaciteit}L | Crew: {br.AantalAstronauten}");
        }
    }
}
