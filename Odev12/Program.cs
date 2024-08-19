using System.Globalization;
using System.Runtime.InteropServices;

namespace Odev12
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            List<Ipiece> list = new List<Ipiece>();
             

            Dictionary<int, Ipiece> randomTaslar = new Dictionary<int, Ipiece>
        {
            { 1, new Pawn() },
            { 2, new Bishop() },
            { 3, new Rook() },
            { 4, new Knight() },
            { 5, new Queen() },
            { 6, new King() }
        };
            Random rndTas = new Random();
            Random rndRenk = new Random();

            int pawnSayac = 0;
            int knightSayac = 0;
            int kingSayac = 0;
            int bishopSayac = 0;
            int queenSayac = 0;
            int rookSayac = 0;

            Console.WriteLine("Çıkmak için H/h basınız. Devam etmek için herhangi bir tuşa basınız.");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();

            while (!(keyInfo.Key == ConsoleKey.H))
            {
                Console.WriteLine();

                int secilenTas = rndTas.Next(1, 7);

                Ipiece secilenClass = randomTaslar[secilenTas];

                int tasRengi = rndRenk.Next(1, 3);

                secilenClass.Color = (tasRengi == 1) ? PieceColor.Black : PieceColor.White; //sanırım burda bir classın rengini atıyorum ve newlemem gerekiyor bir sonrakinde renk ataması için.

                switch (secilenTas)
                {
                    case 1:
                        secilenClass.Name = "Piyon";
                        pawnSayac++;
                        break;
                    case 2:
                        secilenClass.Name = "Fil";
                        bishopSayac++;
                        break;
                    case 3:
                        secilenClass.Name = "Kale";
                        rookSayac++;
                        break;
                    case 4:
                        secilenClass.Name = "At";
                        knightSayac++;
                        break;
                    case 5:
                        secilenClass.Name = "Vezir";
                        queenSayac++;
                        break;
                    case 6:
                        secilenClass.Name = "Şah";
                        kingSayac++;
                        break;
                }

                list.Add(secilenClass);

                Console.WriteLine("Çıkmak için H/h basınız. Devam etmek için herhangi bir tuşa basınız.");
                keyInfo = Console.ReadKey();
                Console.WriteLine();
            }

            foreach (Ipiece item in list)
            {
                Console.WriteLine($"Taş: {item.Name}, Renk: {item.Color}");
                item.Move();
                if (item is Pawn pawn)
                {
                    pawn.Promote();
                }
                Console.WriteLine(new string('-',20));
            }

            SortedDictionary<string, int> tekrarEdenTas = new SortedDictionary<string, int>();

            tekrarEdenTas.Add("At", knightSayac);
            tekrarEdenTas.Add("Piyon", pawnSayac);
            tekrarEdenTas.Add("Fil", bishopSayac);
            tekrarEdenTas.Add("Kale", rookSayac);
            tekrarEdenTas.Add("Vezir", queenSayac);
            tekrarEdenTas.Add("Şah", kingSayac);

            string enCokTekrarEdenTas = "";
            int maxValue = 0;

            foreach (var item in tekrarEdenTas)
            {
                if (item.Value > maxValue)
                {
                    maxValue = item.Value;
                    enCokTekrarEdenTas = item.Key;
                }
            }

            Console.WriteLine($"En çok tekrar eden taş: {enCokTekrarEdenTas} {maxValue} defa");



        }
    }
}


