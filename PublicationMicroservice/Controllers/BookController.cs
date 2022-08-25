using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PublicationMicroservice.Model;
using PublicationMicroservice.Services;

namespace PublicationMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService service;

        public BookController(IBookService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await service.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Book> GetBookById(int id)
        {
            return await service.GetById(id);
        }
        [HttpPost]
        public async Task<Book> AddBook(Book book)
        {
            return await service.Add(book);
        }
        [HttpPut]
        public async Task<Book> UpdateBook(Book book)
        {
            return await service.Update(book);
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeleteBook(int id)
        {
            return await service.Delete(id);
        }
    }
}
