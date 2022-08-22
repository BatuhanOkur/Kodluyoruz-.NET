using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebAPI.Applications.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand
    {
        public readonly IBookStoreDbContext _context;
        
        public int AuthorId { get; set; }
        public UpdateAuthorViewModel Model { get; set; }
        public UpdateAuthorCommand(IBookStoreDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if(author is null)
                throw new InvalidOperationException("Bu yazar daha önceden eklenmiştir!");

            if(_context.Authors.Any(x => 
                    new string(x.Name.ToLower().Trim() + " " + x.Surname.ToLower().Trim()) ==
                    new string(Model.Name.ToLower().Trim() + " " + Model.Surname.ToLower().Trim())
                     && x.Id != AuthorId))
            {
                throw new InvalidOperationException("Bu yazar zaten mevcut!");
            }
            
            author.Name = Model.Name != default ? Model.Name : author.Name;
            author.Surname = Model.Surname != default ? Model.Surname : author.Surname;
            author.BirthDate = Model.BirthDate != default ? Model.BirthDate : author.BirthDate;
            _context.SaveChanges();
        }
    }

    public class UpdateAuthorViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}