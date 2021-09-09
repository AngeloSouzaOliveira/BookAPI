using Domain.Entities;
using Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class AuthorService : IAuthorService
    {
        public AuthorService(IRepositoryAuthor repository)
        {
            Repository = repository;
        }

        public IRepositoryAuthor Repository { get; }

   
        public List<Author> GetAllAuthor()
        {
            return Repository.GetAllAuthor();
        }

        public Author GetById(int id)
        {
            return Repository.GetById(id);
        }

        public Author CreateAuthor(Author authorUp)
        {
            Author author = new Author
            {
                Id = new int(),
                Name = authorUp.Name,
                LastName = authorUp.LastName,
                Email = authorUp.Email,
                BirthDate = authorUp.BirthDate
            };

            Repository.CreateAuthor(author);

            return author;
        }

        public Author UpdateAuthor(int id,
            string name,
            string lastName,
            string email, 
            string birtDate)
        {


            var author = Repository.GetById(id);

            author.Name = name;
            author.LastName = lastName;
            author.Email = email;
            author.BirthDate = Convert.ToDateTime(birtDate);

            Repository.UpdateAuthor(author);

            return author;

        }

        public Author DeleteAuthor(int id)
        {
            var author = Repository.GetById(id);

            Repository.DeleteAuthor(id);

            return null;
        }
    }
}
