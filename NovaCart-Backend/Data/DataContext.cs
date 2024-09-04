using Microsoft.EntityFrameworkCore;

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


    }
}
