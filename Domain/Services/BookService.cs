using Domain.Entities;
using Domain.Repository;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class BookService : IBookService
    {
        public BookService(IRepositoryBook repository)
        {
            Repository = repository;
        }

        public IRepositoryBook Repository { get; }

     
        public List<Book> GetAllBook()
        {
            return Repository.GetAllBook();
        }

        public Book GetById(int id)
        {
            return Repository.GetById(id);
        }

        public Book CreateBook(Book bookLibriry)
        {
            Book book = new Book
            {
                Id = new int(),
                Title = bookLibriry.Title,
                ISBN = bookLibriry.ISBN,
                Year = bookLibriry.Year
            };

            Repository.CreateBook(book);

            return book;

        }

        public Book UpdateBook(int id, string title, string iSBN, string year)
        {
            var bookUp = Repository.GetById(id);

            bookUp.Title = title;
            bookUp.ISBN = iSBN;
            bookUp.Year = Convert.ToDateTime(year);

            Repository.UpdateBook(bookUp);

            return bookUp;


        }

        public Book DeleteBook(int id)
        {
            var book = Repository.GetById(id);

            Repository.DeleteBook(id);

            return null;
        }
    }
}
