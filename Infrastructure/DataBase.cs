using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure
{
    public class DataBase : DbContext
    {
        public DataBase( DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
    }
}
