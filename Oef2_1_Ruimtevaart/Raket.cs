namespace Oef2_1_Ruimtevaart
{
    internal class Raket
    {
        public string Naam { get; set; }
        public int BrandstofCapaciteit { get; set; }

        public Raket(string naam, int brandstof)
        {
            Naam = naam;
            BrandstofCapaciteit = brandstof;
            Console.WriteLine($"Raket aangemaakt: {Naam}");
        }
    }
}
