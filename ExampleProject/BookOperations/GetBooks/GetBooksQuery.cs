using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleProject.DBOperations;
using ExampleProject.Common;
using AutoMapper;

namespace ExampleProject.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        private readonly BookStoreDbContext _dbContext; 
        private readonly IMapper _mapper; 
        public GetBooksQuery(BookStoreDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<BooksViewModel> Handle()
        {
            var books = (from bookStore in _dbContext.Books select bookStore).ToList();
            List<BooksViewModel> vm = _mapper.Map<List<BooksViewModel>>(books);
            return vm;
        }
    }
    public class BooksViewModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}
