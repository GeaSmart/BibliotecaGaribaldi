using PublicationMicroservice.Model;

namespace PublicationMicroservice.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetProductList();
        Task<Book> GetProductById(int id);
        Task<Book> AddProduct(Book book);
        Task<Book> UpdateProduct(Book book);
        Task<bool> DeleteProduct(int id);
    }
}
