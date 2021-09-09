using Domain.Entities;
using System.Collections.Generic;


namespace Domain.Repository
{
    public interface IRepositoryAuthor
    {
        Author GetById(int id);
        List<Author> GetAllAuthor();
        void CreateAuthor(Author author);
        void UpdateAuthor(Author author);
        void DeleteAuthor(int id);
    }
}
