namespace Odev12
{
    public class Pawn : Ipiece
    {
        public string Name { get; set; }
        public PieceColor Color { get; set; }

        public void Move()
        {
            Console.WriteLine("Two forward at the beginning or one forward.");
        }

        public void Promote()
        {
            Console.WriteLine("Can promote to Rook, Knight, Bishop or Queen. ");
        }
    }
}


