using FirstAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]//localhos:port/api/books
    public class BooksController
    { 
        public BooksController() { }

        //GET:api/books
        [HttpGet]
        public async Task<ActionResult <IEnumerable<Book>>> GetBooks()
        {

        }

        //GET:api/books/2
        [HttpGet("{id}")]
        public async Task<ActionResult <Book>> GetBook(int id)
        {

        }

        //POST:api/books
        [HttpPost]
        public async Task <ActionResult <Book>> PostBook(Book book) {
        }

        //PUT:api/books/id
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book) { 
        
        }

        //DELETE:api/books/id
        [HttpDelete("{id}")]
        public async Task<ActionResult <Book> > DeleteBook(int id) { 
        
        }
    }
}
