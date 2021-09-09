using Domain.Entities;
using Domain.Service;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Generated.WebApi.Controllers
{
    [Route("v1/Author")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        public IAuthorService AuthorService { get; }

        public AuthorController(IAuthorService authorService)
        {
            AuthorService = authorService;
        }

        [HttpGet]
        public ActionResult<List<Author>> Get(
            [FromServices] DataBase dataBase)
        {
            var authors = AuthorService.GetAllAuthor();
            return authors;
        }

        [HttpGet]
        [Route("id:int")]
        public ActionResult<List<Author>> GetById(
            int id,
            [FromServices] DataBase dataBase)
        {
            var author = AuthorService.GetById(id);
            return Ok(author);
        }


        [HttpPost]
        [Route("")]
        public ActionResult<Author> Post(
            [FromServices] DataBase dataBase,
            [FromBody] Author author)
        {
            var authorRegister = AuthorService.CreateAuthor(author);
            return Ok(author);

        }

        [HttpPut]
        [Route("id:int")]
        public ActionResult<List<Author>> Put([FromRoute] int id,
            [FromServices] DataBase dataBase,
            [FromBody] Author author)
        {
            var authorUp = AuthorService.UpdateAuthor( author.Id, author.Name, author.LastName, author.Email, author.BirthDate.ToString());
            return Ok(authorUp);
        }


        [HttpDelete]
        [Route("{id:int}")]

        public  ActionResult<List<Author>> Delete ([FromRoute] int id,
            [FromServices] DataBase dataBase)
        {
            var author = AuthorService.DeleteAuthor(id);

            return NoContent();


        }


    }
}
