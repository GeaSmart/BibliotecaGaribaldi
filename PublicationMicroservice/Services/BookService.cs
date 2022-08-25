using Microsoft.EntityFrameworkCore;
using PublicationMicroservice.Data;
using PublicationMicroservice.Model;

namespace PublicationMicroservice.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext context;

        public BookService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Book>> GetProductList()
        {
            return await context.Books.ToListAsync();
        }
        public async Task<Book> GetProductById(int id)
        {
            return await context.Books.Where(x => x.BookId == id).FirstOrDefaultAsync();
        }
        public async Task<Book> AddProduct(Book book)
        {
            var result = context.Books.Add(book);
            await context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Book> UpdateProduct(Book book)
        {
            var result = context.Books.Update(book);
            await context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<bool> DeleteProduct(int id)
        {
            var filteredData = await context.Books.Where(x => x.BookId == id).FirstOrDefaultAsync();
            var result = context.Remove(filteredData);
            await context.SaveChangesAsync();
            return result != null;
        }
    }
}
