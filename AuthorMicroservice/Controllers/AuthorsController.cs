using AuthorMicroservice.Model;
using AuthorMicroservice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService service;

        public AuthorsController(IAuthorService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await service.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Author> GetAuthorById(int id)
        {
            return await service.GetById(id);
        }
        [HttpPost]
        public async Task<Author> AddAuthor(Author author)
        {
            return await service.Add(author);
        }
        [HttpPut]
        public async Task<Author> UpdateAuthor(Author author)
        {
            return await service.Update(author);
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeleteAuthor(int id)
        {
            return await service.Delete(id);    
        }
    }
}
