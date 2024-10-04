using Microsoft.EntityFrameworkCore;

namespace Final_Project.Models
{
    public class FinalProjectContext:DbContext
    {
        public FinalProjectContext() : base() { }
        public FinalProjectContext(DbContextOptions options) : base(options) { }
        public DbSet<products> products { get; set; }
        public DbSet<product_category> products_category { get; set; }
        public DbSet<categories> categories { get; set; }
        public DbSet<order_details> order_details { get; set; }
        public DbSet<orders> orders  { get; set; }
        public DbSet<customers> customers  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=final_project;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<product_category>().HasKey("category_id", "product_id");
            modelBuilder.Entity<order_details>().HasKey("product_id", "order_id");
           
        }
    }
}
