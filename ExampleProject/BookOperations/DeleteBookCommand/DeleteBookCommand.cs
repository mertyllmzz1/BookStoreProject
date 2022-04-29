using ExampleProject.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.BookOperations.DeleteBookCommand
{
    
    public class DeleteBookCommand
    {
        private readonly BookStoreDbContext _dbContext;
        public int BookId { get; set; }
        public DeleteBookCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.ID == BookId);
            if (book is null)
                throw new InvalidOperationException();
            _dbContext.Remove(book);
            _dbContext.SaveChanges();
        }
    }
}
