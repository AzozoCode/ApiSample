 using API.Interfaces;
using Library_Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBook repo;

        public BooksController(IBook repo)
        {
            this.repo = repo; 
        }

        [HttpGet("GetBooks")]
        public async Task<IActionResult> GetBooks()
        {
            var books = await repo.GetBooks();
            return Ok(books);
        }

        [HttpGet("GetBook/{id}")]
        public async Task<IActionResult> GetBook([FromRoute] int id)
        {
            var book = await Task.Run(() => repo.GetBook(id));
            return Ok(book);
        }

        [HttpPost("PostBook")]
        public async Task<IActionResult> PostBook([FromBody] Book book)
        {
            repo.AddBook(book);
            await repo.SaveChanges();
            return CreatedAtAction("GetBook", new { id = book.BookID}, book);
        }

        [HttpPut("PutBook")]
        public async Task<IActionResult> PutBook(Book book)
        {
            repo.UpdateBook(book);
            await repo.SaveChanges();

            return NoContent();
        }

        [HttpDelete("DeleteBook")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            repo.DeleteBook(id);
            await repo.SaveChanges();

            return NoContent();
        }
    }
}
