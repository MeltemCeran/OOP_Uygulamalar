namespace Odev_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sebze sebze = new Sebze();

            sebze.Fiyat = (decimal)14.99;

            Console.WriteLine(sebze.Fiyat);

            Domates domates = new Domates("Salkim domates","KG");

            Console.WriteLine(sebze.BirimiGetir()); 


            


        }
    }
}
