using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.Queries.GetGenreDetail
{
    public class GetGenreDetailQuery
    {
        public int GenreId {get; set;}
        private readonly IBookStoreDbContext _context;

        private readonly IMapper _mapper;
        public GetGenreDetailQuery(IBookStoreDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public GetGenreDetailViewModel Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.IsActive && x.Id == GenreId);
            if(genre is null)
                throw new InvalidOperationException("Kitap türü bulunamadı.");
            
            GetGenreDetailViewModel returnObj = _mapper.Map<GetGenreDetailViewModel>(genre);
            return returnObj;
        }

    }

    public class GetGenreDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}