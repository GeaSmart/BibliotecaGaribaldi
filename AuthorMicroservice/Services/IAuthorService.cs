using AuthorMicroservice.Model;

namespace AuthorMicroservice.Services
{
    public interface IAuthorService
    {
        Task<Author> AddProduct(Author author);
        Task<bool> DeleteProduct(int Id);
        Task<Author> GetProductById(int id);
        Task<IEnumerable<Author>> GetProductList();
        Task<Author> UpdateProduct(Author author);
    }
}
