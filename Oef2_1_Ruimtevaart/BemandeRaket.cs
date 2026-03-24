namespace Oef2_1_Ruimtevaart
{
    internal class BemandeRaket : Raket
    {
        public int AantalAstronauten { get; set; }

        // TODO: maak de constructor af.
        //   - Geef naam en brandstof door aan de parent via base(...)
        //   - Stel AantalAstronauten in
        //   - Log: "Bemande raket klaar voor [aantalAstronauten] astronauten."
        public BemandeRaket(string naam, int brandstof, int aantalAstronauten) : base(naam, brandstof)
        {
            // vul hier aan
        }
    }
}
