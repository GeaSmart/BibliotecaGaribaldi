using AuthorMicroservice.Data;
using AuthorMicroservice.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthorMicroservice.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly ApplicationDbContext context;

        public AuthorService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Author>> GetProductList()
        {
            return await context.Authors.ToListAsync();
        }
        public async Task<Author> GetProductById(int id)
        {
            return await context.Authors.Where(x => x.AuthorId == id).FirstOrDefaultAsync();
        }
        public async Task<Author> AddProduct(Author author)
        {
            var result = context.Authors.Add(author);
            await context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Author> UpdateProduct(Author author)
        {
            var result = context.Authors.Update(author);
            await context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<bool> DeleteProduct(int Id)
        {
            var filteredData = context.Authors.Where(x => x.AuthorId == Id).FirstOrDefaultAsync();
            var result = context.Remove(filteredData);
            await context.SaveChangesAsync();
            return result != null;
        }
    }
}
