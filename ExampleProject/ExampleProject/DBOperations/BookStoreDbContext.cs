using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.DBOperations
{
    public class BookStoreDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               
                
                optionsBuilder.UseSqlServer("Data Source=OZATA-LT-188\\SQLEXPRESS;Initial Catalog=BOOKSTORE;Integrated Security=true; Connection Timeout=60000");
            }
        }
        public BookStoreDbContext()
        {
        }
        public BookStoreDbContext(DbContextOptions options=null) :base(options)
        {
           
        }
        public DbSet<Book> Books { get; set; }
    }
}
