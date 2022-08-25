using PublicationMicroservice.Model;

namespace PublicationMicroservice.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAll();
        Task<Book> GetById(int id);
        Task<Book> Add(Book book);
        Task<Book> Update(Book book);
        Task<bool> Delete(int id);
    }
}
