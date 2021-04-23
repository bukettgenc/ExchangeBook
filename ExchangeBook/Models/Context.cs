using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExchangeBook.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9AF7PPH\\SQLEXPRESS; database=ExchangeBook; integrated security=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<MyBook> MyBooks { get; set; }
        public DbSet<MyFav> MyFavs { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Opinion> Opinions { get; set; }
    }
}
