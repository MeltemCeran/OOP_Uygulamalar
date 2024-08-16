namespace UygulamaCalismalari_1
{
    internal class Akademisyen : Insan
    {
        public string Mail { get; set; }

        public string Program { get; set; }

        public virtual void BilgileriAl()
        {
            base.BilgileriAl();
            Console.WriteLine("Lütfen Mailinizi Yazınız:");
            Mail = Console.ReadLine();
            Console.WriteLine("Lütfen Programınızı Yazınız:");
            Program = Console.ReadLine();

        }

        public virtual void BilgileriGoster()
        {
            base.BilgileriGoster();
            Console.WriteLine($"Mail {Mail}, Program {Program}");
        }
    }
}
