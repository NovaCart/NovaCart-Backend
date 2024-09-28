using Microsoft.EntityFrameworkCore;
using NovaCart_Backend.Models;

namespace NovaCart_Backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.; initial Catalog=novacartdb ; User Id=sa; password=1234; TrustServerCertificate= True");
        }

        public DbSet<Cloth> Cloths { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SizeAvailability> SizeAvailability { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cloth>()
                .HasMany(c => c.SizeAvailability)
                .WithOne(a => a.Cloth)
                .HasForeignKey(a => a.ClothId);

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithOne(a => a.Cart)
                .HasForeignKey<Cart>(c => c.UserId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.UserId);
        }
    }
}
