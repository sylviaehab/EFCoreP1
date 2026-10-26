using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreP1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreP1
{
    public class AppDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1840995\\SQLEXPRESS03;Database=EFCoreP1;Trusted_Connection=True;trustservercertificate=true");
        }
    }
}
