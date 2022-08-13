using System;
using System.Linq;
using AutoMapper;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.Application.BookOperations.Queries.GetBookDetail
{
    public class GetBookDetailQuery
    {
        public int BookId {get; set;}
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetBookDetailQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public GetBookDetailModel Handle()
        {
            var book = _dbContext.Books.Where(book=> book.Id == BookId).SingleOrDefault();
            if(book is null)
                throw new InvalidOperationException("Kitap bulunamadı!");
            GetBookDetailModel vm = _mapper.Map<GetBookDetailModel>(book);//new GetBookDetailModel();
            // vm.Title = book.Title;
            // vm.Genre = ((GenreEnum)book.GenreId).ToString();
            // vm.PageCount = book.PageCount;
            // vm.PublishDate = book.PublishDate.Date.ToString("dd/MM/yyy");
            return vm;
        }
    }

    public class GetBookDetailModel
    {
        public string Title { get; set; }
        public string Genre {get; set;}
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        
    }
}