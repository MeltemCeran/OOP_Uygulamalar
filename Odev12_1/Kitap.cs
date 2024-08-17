namespace Odev12_1
{
    public class Kitap : BaseKitap 
    {
        public override void GetLog()
        {
            Console.WriteLine("Kitap get user..");
        }
        public sealed override void GetUser()
        {
            Console.WriteLine("Kitap get user...");
        }
    }
}
