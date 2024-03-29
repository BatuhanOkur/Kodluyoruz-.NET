using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommand
    {
        public CreateAuthorViewModel Model {get; set;}
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;

        public CreateAuthorCommand(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => new string(x.Name.ToLower().Trim() + " " + x.Surname.ToLower().Trim())
            == new string(Model.Name.ToLower().Trim() + " " +Model.Surname.ToLower().Trim()));
            if(author is not null)
                throw new OverflowException("Bu yazar zaten mevcut!");
            var newAuthor = _mapper.Map<Author>(Model);    
            _context.Authors.Add(newAuthor);
            _context.SaveChanges();
        }
    }

    public class CreateAuthorViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate {get; set;}
    }
}