namespace Oef1_1_Bibliotheek
{
    // TODO: laat Tijdschrift erven van Publicatie
    internal class Tijdschrift
    {
        public int Editie { get; set; }

        public Tijdschrift(string titel, int jaar, int editie)
        {
            // TODO: stel Titel in (geërfde property van Publicatie)
            // Titel = titel;

            // TODO: stel _jaar in (geërfd protected veld van Publicatie)
            // _jaar = jaar;

            Editie = editie;
        }

        public void ToonTijdschriftInfo()
        {
            // TODO: roep ToonInfo() aan (geërfde methode van Publicatie)
            // ToonInfo();
            Console.WriteLine($"  Editie: {Editie}");
        }
    }
}
