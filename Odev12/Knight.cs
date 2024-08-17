namespace Odev12
{
    public class Knight : Ipiece
    {
        public string Name { get; set; }
        public PieceColor Color { get; set; }

        public void Move()
        {
            Console.WriteLine("L shaped only");
        }
    }
}


