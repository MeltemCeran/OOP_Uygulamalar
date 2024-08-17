namespace Odev12
{
    public class Bishop : Ipiece
    {
        public string Name { get; set; }
        public PieceColor Color { get; set; }

        public void Move()
        {
            Console.WriteLine("Diagonals only");
        }
    }
}


