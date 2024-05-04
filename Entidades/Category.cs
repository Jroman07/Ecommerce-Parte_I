
namespace Entidades
{
    public class Category
    {
        public int Id {set;get;}
        public string Name {  get; set; }
        public bool State = true;
        List<Shoe>? shoes {  get; set; }
    }
}
