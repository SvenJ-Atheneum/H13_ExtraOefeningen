namespace Oef1_1_Bibliotheek
{
    // Oefening 1.1 – Bibliotheek (protected + overerving)
    // Pas Publicatie.cs en Tijdschrift.cs aan zodat onderstaande output klopt.
    //
    // Verwachte output:
    //   Titel: National Geographic (2024)
    //     Editie: 3

    internal class Program
    {
        static void Main(string[] args)
        {
            Tijdschrift t = new Tijdschrift("National Geographic", 2024, 3);
            t.ToonTijdschriftInfo();
        }
    }
}
