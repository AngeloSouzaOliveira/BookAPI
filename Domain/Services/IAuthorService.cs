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
    public interface IAuthorService
    {
        IRepositoryAuthor Repository { get; }

        List<Author> GetAllAuthor();

        Author GetById(int id);

        Author CreateAuthor(Author author);

        Author UpdateAuthor(int id, string name, string lastName, string email, string birtDate);

        Author DeleteAuthor(int id);
    }
}
