namespace Odev12
{
    public class King: Ipiece
    {
        public string Name { get; set; }
        public PieceColor Color { get; set; }

        public void Move()
        {
            Console.WriteLine("Rook + Bishop + One");
        }
    }
}


