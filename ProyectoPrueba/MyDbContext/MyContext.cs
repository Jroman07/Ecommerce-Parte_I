using Entidades
using Microsoft.EntityFrameworkCore;

namespace Services.MyDbContext
{
    public class MyContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }

        public DbSet<Shoe> Shoes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasOne(shoe => shoe.Category)
                .WithMany(category => category.Shoes);
        }
    }
}
