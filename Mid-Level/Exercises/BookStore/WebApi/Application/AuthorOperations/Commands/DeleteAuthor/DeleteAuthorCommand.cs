using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeteleAuthorCommand
    {
        private readonly BookStoreDbContext _context;

        public DeteleAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }

        public int AuthorId { get; set; }

        public void Handle()
        {
            var author = _context.Authors.SingleOrDefault(x => x.Id == AuthorId);
            if(author is null)
                throw new InvalidOperationException("Silinmek istenen yazar bulunamadı.");

            // Yazarın yayında kitabı varsa silinemeyecek.
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
        
    }
}