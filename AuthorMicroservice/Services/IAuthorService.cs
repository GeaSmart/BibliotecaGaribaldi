using AuthorMicroservice.Model;

namespace AuthorMicroservice.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetProductList();
        Task<Author> GetProductById(int id);
        Task<Author> AddProduct(Author author);
        Task<Author> UpdateProduct(Author author);
        Task<bool> DeleteProduct(int Id);        
    }
}
