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

        public async Task<IEnumerable<Author>> GetAll()
        {
            return await context.Authors.ToListAsync();
        }
        public async Task<Author> GetById(int id)
        {
            return await context.Authors.Where(x => x.AuthorId == id).FirstOrDefaultAsync();
        }
        public async Task<Author> Add(Author author)
        {
            var result = context.Authors.Add(author);
            await context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Author> Update(Author author)
        {
            var result = context.Authors.Update(author);
            await context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<bool> Delete(int Id)
        {
            var filteredData = await context.Authors.Where(x => x.AuthorId == Id).FirstOrDefaultAsync();
            var result = context.Remove(filteredData);
            await context.SaveChangesAsync();
            return result != null;
        }
    }
}
