using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        private readonly IBookStoreDbContext _context;

        public DeleteAuthorCommand(IBookStoreDbContext context)
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
            var hasBook = _context.Books.SingleOrDefault(x=> x.AuthorId == AuthorId);
            if(hasBook is not null)
                throw new InvalidOperationException("Silmeye çalıştığınız yazarın yayında kitabı var, önce kitap silinmeli!"); 
                
            _context.Authors.Remove(author);
            _context.SaveChanges();
        }
        
    }
}