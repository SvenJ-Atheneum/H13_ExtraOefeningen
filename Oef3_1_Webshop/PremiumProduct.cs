namespace Oef3_1_Webshop
{
    internal class PremiumProduct : Product
    {
        public PremiumProduct(string naam, double prijs) : base(naam, prijs) { }

        // TODO 1: voeg het juiste keyword toe om BerekenKorting te overschrijven
        // TODO 2: bereken de korting als: basiskorting (via base.BerekenKorting()) + 10% van de prijs
        public double BerekenKorting()
        {
            return 0; // vervang dit door de correcte berekening
        }
    }
}
