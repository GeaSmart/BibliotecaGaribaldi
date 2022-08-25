using AuthorMicroservice.Model;

namespace AuthorMicroservice.Services
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAll();
        Task<Author> GetById(int id);
        Task<Author> Add(Author author);
        Task<Author> Update(Author author);
        Task<bool> Delete(int Id);        
    }
}
