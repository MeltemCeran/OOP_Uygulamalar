namespace Odev12
{
    public class Queen : Ipiece
    {
        public string Name { get; set; }
        public PieceColor Color { get; set; }

        public void Move()
        {
            Console.WriteLine("Rook + Bishop");
        }
    }
}


