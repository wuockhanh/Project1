using AutoMapper;
using Project1.Data;
using Project1.Models;

namespace Project1.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() {
            CreateMap<Book, BookModel>().ReverseMap();

        
        }
    }
}
