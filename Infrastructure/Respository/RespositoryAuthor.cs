using Domain.Entities;
using Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Respository
{
    public class RespositoryAuthor : IRepositoryAuthor
    {
        
        private DataBase db { get; set; }

        public RespositoryAuthor(DataBase dataBase)
        {
            db = dataBase;
        }

        //Retorna a lista com todos autores
        public List<Author> GetAllAuthor()
        {
            var authors =  db.authors.Include(x => x.books).AsNoTracking().ToList();
            return authors;
        }

        //Retorna um autor apartir de um id
        public Author GetById(int id)
        {
            var author = db.authors.Include(x => x.books).FirstOrDefault(x => x.Id == id);
            return author;
        }

        //Cria um autor
        public void CreateAuthor(Author author)
        {
            db.authors.Add(author);
            db.SaveChangesAsync();
   
        }

        // Atualiza um autor
        public void UpdateAuthor(Author author)
        {
            db.Entry<Author>(author).State = EntityState.Modified;
            db.SaveChangesAsync();
        }


        //Remove um autor
        public void DeleteAuthor(int id)
        {
            var author = db.authors.FirstOrDefault(x => x.Id == id);
            db.authors.Remove(author);
            db.SaveChangesAsync();

        }

       
    }
}
