namespace Oef1_2_Medewerkers
{
    // Oefening 1.2 – Medewerkers (protected + overerving)
    // Maak Medewerker.cs en Manager.cs volledig zelf.
    // Deze Program.cs mag je NIET aanpassen.
    // Als jouw klassen correct zijn, verschijnt onderstaande output vanzelf.
    //
    // Verwachte output:
    //   Naam: Sara | Uurloon: €45,00
    //     Afdeling: IT

    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager("Sara", 45.0, "IT");
            m.ToonManagerInfo();
        }
    }
}
