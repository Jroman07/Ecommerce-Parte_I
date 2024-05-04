using Entidades;
namespace ProyectoPrueba.Services.Service_Shoe
{
    public interface ISvShoe
    {
        //READS
        public List<Shoe> GetAllShoes();
        public Shoe GetShoeById(int id);

        //WRITES
        public Shoe AddShoe(Shoe shoe);
        public Shoe UpdateShoe(int id, Shoe shoe);
        public void DeleteShoe(int id);
    }
}
