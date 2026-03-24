namespace Oef1_1_Bibliotheek
{
    internal class Publicatie
    {
        public string Titel { get; set; }

        // TODO: verander 'private' naar het juiste access modifier zodat
        //       child-klassen dit veld kunnen gebruiken, maar buitenstaanders niet.
        private int _jaar;

        public Publicatie(string titel, int jaar)
        {
            Titel = titel;
            _jaar = jaar;
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Titel: {Titel} ({_jaar})");
        }
    }
}
