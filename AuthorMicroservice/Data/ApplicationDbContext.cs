using AuthorMicroservice.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthorMicroservice.Data
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

        public DbSet<Author> Authors { get; set; }
    }
}
