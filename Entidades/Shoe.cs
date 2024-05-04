namespace Entidades
{
    public class Shoe
    {
        public int Id { get; set; }
        public float Size { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public bool State = true;
        public int IdCategory { get; set; }
    }
}
