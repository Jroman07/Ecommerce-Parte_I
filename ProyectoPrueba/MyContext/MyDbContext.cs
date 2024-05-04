using Entidades;
using Microsoft.EntityFrameworkCore;

namespace ProyectoPrueba.MyContext
{
    public class MyDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

        }

        public DbSet<Shoe> Shoes { get; set; }
    }
}
