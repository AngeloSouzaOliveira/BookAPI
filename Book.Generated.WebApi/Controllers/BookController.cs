using Domain.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure;

namespace Book.Generated.WebApi.Controllers
{
    [Route("v1/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public IBookService BookService { get; }

        public BookController(IBookService bookService)
        {
            BookService = bookService;
        }

        [HttpGet]
        public ActionResult<List<Domain.Entities.Book>> Get()
        {
            var books = BookService.GetAllBook();
            return books;
        }

        [HttpGet]
        [Route("id:int")]
        public  ActionResult<List<Domain.Entities.Book>> GetById(
            int id,
            [FromServices] DataBase dataBase)
        {
            var book = BookService.GetById(id);
            return Ok(book);
        }


        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Domain.Entities.Book>> Post(
            [FromServices] DataBase dataBase,
            [FromBody] Domain.Entities.Book book)
        {
            var bookRegister = BookService.CreateBook(book);
            return Ok(book);

        }

        [HttpPut]
        [Route("id:int")]
        public ActionResult<List<Domain.Entities.Book>> Put([FromRoute] int id,
            [FromServices] DataBase dataBase,
            [FromBody] Domain.Entities.Book book)
        {
            var bookup = BookService.UpdateBook(book.Id, book.Title, book.ISBN, book.Year.ToString());
            return Ok(book);
        }


        [HttpDelete]
        [Route("{id:int}")]

        public ActionResult<List<Author>> Delete([FromRoute] int id,
            [FromServices] DataBase dataBase)
        {
            var book = BookService.DeleteBook(id);

            return NoContent();


        }



    }
}
