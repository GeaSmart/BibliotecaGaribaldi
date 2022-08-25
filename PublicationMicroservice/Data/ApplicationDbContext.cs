using Microsoft.EntityFrameworkCore;
using PublicationMicroservice.Model;

namespace PublicationMicroservice.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Book> Books { get; set; }
    }
}
