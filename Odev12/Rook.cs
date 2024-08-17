namespace Odev12
{
    public class Rook : Ipiece
    {
        public string Name { get; set; }
        public PieceColor Color { get; set; }

        public void Move()
        {
            Console.WriteLine("Ranks and files only");
        }
    }
}


