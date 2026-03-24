namespace Oef2_2_Muziekband
{
    // Oefening 2.2 – Muziekband (constructors bij overerving)
    // Maak Artiest.cs en Bandlid.cs volledig zelf.
    // Deze Program.cs mag je NIET aanpassen.
    // Als jouw klassen correct zijn, verschijnt onderstaande output vanzelf.
    //
    // Verwachte output:
    //   Artiest geregistreerd: Elien
    //   Bandlid toegevoegd aan The Crashed
    //   Elien | Rock | Band: The Crashed

    internal class Program
    {
        static void Main(string[] args)
        {
            Bandlid bl = new Bandlid("Elien", "Rock", "The Crashed");
            Console.WriteLine($"{bl.Naam} | {bl.Genre} | Band: {bl.BandNaam}");
        }
    }
}
