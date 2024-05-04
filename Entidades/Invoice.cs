
namespace Entidades
{
    public class Invoice
    {
        public int Id { get; set; }
        public int IdCostumer { get; set; }
        public Customer customer { get; set; }
        public List<Shoe>? shoes { get; set; }
    }
}
