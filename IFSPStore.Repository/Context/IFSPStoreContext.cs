using IFSPStore.Domain.Entities;
// using IFSPStore.Repository.Mapping; // <--- Comentei ou removi isso
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Context
{
    public class IFSPStoreContext : DbContext
    {
        public IFSPStoreContext(DbContextOptions<IFSPStoreContext>? op = null) : base(op ?? new DbContextOptions<IFSPStoreContext>())
        {
        }

        // Configuração de contingência (caso o ConfigureDI falhe)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;database=ifspstore;user=root;password=admin");
            }
        }

        // Tabelas
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Costumer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SalesItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- REMOVI OS MAPS ANTIGOS QUE ESTAVAM CAUSANDO CONFLITO ---
            // modelBuilder.Entity<Product>(new ProductMap().Configure);
            // ...

            // --- CONFIGURAÇÃO MANUAL CORRETA ---
            // Aqui dizemos explicitamente qual tabela usar para cada classe.

            modelBuilder.Entity<User>().ToTable("user");
            modelBuilder.Entity<City>().ToTable("city");
            modelBuilder.Entity<Category>().ToTable("category");
            modelBuilder.Entity<Product>().ToTable("product");

            // Sua classe chama 'Costumer', mas a tabela no banco é 'customer'
            modelBuilder.Entity<Costumer>().ToTable("customer");

            modelBuilder.Entity<Sale>().ToTable("sale");
            modelBuilder.Entity<SaleItem>().ToTable("saleitem");
        }
    }
}