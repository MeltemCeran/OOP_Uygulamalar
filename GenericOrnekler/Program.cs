namespace GenericOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Hayvan
    {

    }

    public class EvcilHayvan
    {

    }

    public class Kopek
    {

    }

    public class Kedi
    {

    }

    public class KopekTurleri<T>
    {
        public KopekTurleri(T cinsi, string adı)
        {
            Cinsi = cinsi;
            Adı = adı;
        }

        public T Cinsi { get; set; }

        public string Adı { get; set; }
        
    }

    public class Doberman 
    {
       
    }

    public class Pitbull
    {

    }

    public class KediTurleri<T>
    {

    }
}
