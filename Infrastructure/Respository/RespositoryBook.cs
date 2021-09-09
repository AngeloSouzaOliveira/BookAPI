using Domain.Entities;
using Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Respository
{
    public class RespositoryBook : IRepositoryBook
    {
        private DataBase db { get; set; }

        public RespositoryBook(DataBase dataBase)
        {
            db = dataBase;
        }

        //Retorna a lista com todos os livros
        public List<Book> GetAllBook()
        {
           var books =  db.books.AsNoTracking().AsNoTracking().ToList();
            return books;
        }

        //Retorna um livro apatir de um id
        public Book GetById(int id)
        {
            var book =  db.books.FirstOrDefault(x => x.Id == id);
            return book;
        }

        //Cria um livro
        public void CreateBook(Book book)
        {
            db.books.Add(book);
            db.SaveChanges();
        }

        //Atualiza um livro
        public void UpdateBook(Book book)
        {
            db.Entry<Book>(book).State = EntityState.Modified;
            db.SaveChanges();
        }

        ////Deleta um livro apartir do id
        public void DeleteBook(int id)
        {
            var book = db.books.FirstOrDefault(x => x.Id == id);
            db.books.Remove(book);
            db.SaveChanges();
        }

        
    }
}
