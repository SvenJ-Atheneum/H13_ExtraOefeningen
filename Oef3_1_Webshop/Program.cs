namespace Oef3_1_Webshop
{
    // Oefening 3.1 – Webshop (virtual / override / base)
    // Pas Product.cs en PremiumProduct.cs aan zodat onderstaande output klopt.
    //
    // Verwachte output:
    //   Koptelefoon      | Prijs: €80,00 | Korting: €4,00
    //   Koptelefoon Pro  | Prijs: €80,00 | Korting: €12,00

    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("Koptelefoon", 80);
            PremiumProduct pp = new PremiumProduct("Koptelefoon Pro", 80);

            p.ToonInfo();
            pp.ToonInfo();
        }
    }
}
