namespace UygulamaCalismalari_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Araba araba = new Araba();
            //araba.Git();

            MotorluTasit motorluTasit = new MotorluTasit();
            motorluTasit.Git();

            Console.WriteLine("---------");

            Araba araba123 = new Araba();
            araba123.Git();

            MotorluTasit araba321 = new Araba();
            araba321.Git();



            
        }
    }
}
