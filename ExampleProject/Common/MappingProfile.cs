using AutoMapper;
using ExampleProject.BookOperations.GetBookDetail;
using ExampleProject.BookOperations.GetBooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ExampleProject.BookOperations.CreateBook.CreateBookCommand;

namespace ExampleProject.Common
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();
            CreateMap<Book,BookDetailViewModel>().ForMember(dest=> dest.Genre,opt=>opt.MapFrom(src=>((GenreEnums)src.GenreId).ToString()));
            CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnums)src.GenreId).ToString()));
        }
    }
}
