 using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleProject.DBOperations;
namespace ExampleProject
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            ////Db db = new Db();
            //BookStoreDbContext dbContext = new BookStoreDbContext();
            //Book book = new Book();
            //book.ID = 1;
            //book.Title = "Olasýlýksýz";
            //book.PageCount = 540;
            //book.PublishDate =new DateTime(2007,4,15);
            //dbContext.Add(book);
            //dbContext.SaveChanges();
           
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
