using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthors
{
    public class GetAuthorsQuery
    {
        private readonly BookStoreDbContext _context;

        private readonly IMapper _mapper;

        public GetAuthorsQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<GetAuthorsViewModel> Handle()
        {
            var authorList = _context.Authors.OrderBy(x => x.Id).ToList<Author>();
            List<GetAuthorsViewModel> vm = _mapper.Map<List<GetAuthorsViewModel>>(authorList);
            return vm;
        }

        
    }

    public class GetAuthorsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
    }
}