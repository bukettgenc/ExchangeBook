using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eksiSozluk.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9AF7PPH\\SQLEXPRESS; database=eksiDictionary; integrated security=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<HomePage> HomePages { get; set; }
    }
}
