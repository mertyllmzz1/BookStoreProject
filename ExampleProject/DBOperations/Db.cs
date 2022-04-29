using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.DBOperations
{ 
    public class Db
    {
        private BookStoreDbContext _context;
        public BookStoreDbContext context;
        public Db()
        {
         
        }
    }
}
