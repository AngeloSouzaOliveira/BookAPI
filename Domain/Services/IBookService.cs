using Domain.Entities;
using Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IBookService
    {
        IRepositoryBook Repository { get; }

        List<Book> GetAllBook();

        Book GetById(int id);

        Book CreateBook(Book bookLibriry);

        Book UpdateBook(int id, string title, string iSBN, string year);

        Book DeleteBook(int id);



    }
}
