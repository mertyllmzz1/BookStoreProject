using AutoMapper;
using ExampleProject.Common;
using ExampleProject.DBOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.BookOperations.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int BookId{ get; set; }

        public GetBookDetailQuery(BookStoreDbContext dbContext,IMapper mapper)
        {
            _dbContext = dbContext;
        }
        public BookDetailViewModel Handle()
        {
            var book = (from bookStore in _dbContext.Books where bookStore.ID == BookId select bookStore).SingleOrDefault();
            if (book is null)
                throw new InvalidOperationException("Kitap bulunamadı");
            BookDetailViewModel vm = _mapper.Map<BookDetailViewModel>(book);


            return vm;
        }
     
    }
    public class BookDetailViewModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
    }
}
