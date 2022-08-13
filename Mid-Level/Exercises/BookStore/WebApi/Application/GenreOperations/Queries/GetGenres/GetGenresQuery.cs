using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Application.GenreOperations.Queries.GetGenres
{
    public class GetGenresQuery
    {
        private readonly BookStoreDbContext _context;

        private readonly IMapper _mapper;
        public GetGenresQuery(BookStoreDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public List<GetGenresViewModel> Handle()
        {
            var genres = _context.Genres.Where(x => x.IsActive).OrderBy(x=>x.Id);
            List<GetGenresViewModel> returnObj = _mapper.Map<List<GetGenresViewModel>>(genres);
            return returnObj;
        }

    }

    public class GetGenresViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}