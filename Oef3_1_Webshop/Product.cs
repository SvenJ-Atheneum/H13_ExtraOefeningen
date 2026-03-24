namespace Oef3_1_Webshop
{
    internal class Product
    {
        public string Naam { get; set; }
        public double Prijs { get; set; }

        public Product(string naam, double prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

        // TODO: voeg het juiste keyword toe zodat child-klassen
        //       deze methode kunnen overschrijven.
        public double BerekenKorting()
        {
            return Prijs * 0.05; // standaard 5% korting
        }

        public void ToonInfo()
        {
            Console.WriteLine($"{Naam} | Prijs: €{Prijs:F2} | Korting: €{BerekenKorting():F2}");
        }
    }
}
