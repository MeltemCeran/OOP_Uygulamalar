namespace UygulamaCalismalari_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sube sube = new Sube();
            //sube.Departman = Departmanlar.Uretim;
            //Console.WriteLine(sube.Departman);


            List<Sube> subeler = new List<Sube>();

            Sube sube;
            int kod;
            int tus;
            int uretimsayac = 0;
            int pazarlamasayac = 0;
            int finanssayac = 0;

            Console.WriteLine("Şube oluşturmak için 1'e çıkmak için herhangi bir tuşa basınız:");
            tus = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (tus != 1)
                    break;

                sube = new Sube();
                Console.WriteLine("Şube departmanını belirlemek üzere; Üretim için 1'e, Pazarlama için 2'ye, Finans için 3'e basınız.");
                kod = Convert.ToInt32(Console.ReadLine());

                while (kod != 1 && kod != 2 && kod != 3)
                {
                    Console.WriteLine("Şube departmanını belirlemek üzere; Üretim için 1'e, Pazarlama için 2'ye, Finans için 3'e basınız.");
                    kod = Convert.ToInt32(Console.ReadLine());
                }
                if (kod == (int)Departmanlar.Uretim)
                {
                    sube.Departman = Departmanlar.Uretim;
                    uretimsayac++;
                }
                else if (kod == (int)Departmanlar.Pazarlama)
                {
                    sube.Departman = Departmanlar.Pazarlama;
                    pazarlamasayac++;
                }
                else if (kod == (int)Departmanlar.Finans)
                {
                    sube.Departman = Departmanlar.Finans;
                    finanssayac++;
                }
                subeler.Add(sube);

                Console.WriteLine(sube.Departman);

                Console.WriteLine("Devam etmek için 1'e çıkmak için herhangi bir tuşa basınız:");
                tus = Convert.ToInt32(Console.ReadLine());

            } while (tus == 1);

            Console.WriteLine($"Üretim : {uretimsayac} , pazarlama {pazarlamasayac}, finans {finanssayac}");


        }
    }

    public class Sube
    {
        public Departmanlar Departman { get; set; }
    }

    public enum Departmanlar
    {
        Uretim = 1,
        Pazarlama = 2,
        Finans =3,
    }
}
