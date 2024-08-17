namespace Odev12
{
    public interface Ipiece
    {
        string Name { get; set; }
        public PieceColor Color { get; set; }
        public void Move();

    }
}


