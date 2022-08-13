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
        private readonly BookStoreDbContext _context;

        private readonly IMapper _mapper;
        public GetGenreDetailQuery(IMapper mapper, BookStoreDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public GetGenresViewModel Handle()
        {
            var genre = _context.Genres.SingleOrDefault(x => x.IsActive && x.Id == GenreId);
            if(genre is null)
                throw new InvalidOperationException("Kitap türü bulunamadı.");
            
            GetGenresViewModel returnObj = _mapper.Map<GetGenresViewModel>(genre);
            return returnObj;
        }

    }

    public class GetGenresViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}