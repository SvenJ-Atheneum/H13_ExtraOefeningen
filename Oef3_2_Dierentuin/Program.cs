namespace Oef3_2_Dierentuin
{
    // Oefening 3.2 – Dierentuin (virtual / override / base)
    // Maak Dier.cs en Roofdier.cs volledig zelf.
    // Deze Program.cs mag je NIET aanpassen.
    // Als jouw klassen correct zijn, verschijnt onderstaande output vanzelf.
    //
    // Verwachte output:
    //   Zebra krijgt 900g per dag
    //   Leeuw krijgt 940g per dag

    internal class Program
    {
        static void Main(string[] args)
        {
            Dier d = new Dier { Naam = "Zebra", GewichtKg = 300 };
            Roofdier r = new Roofdier { Naam = "Leeuw", GewichtKg = 180, JachtBonus = 4 };

            d.ToonVoeding();
            r.ToonVoeding();
        }
    }
}
