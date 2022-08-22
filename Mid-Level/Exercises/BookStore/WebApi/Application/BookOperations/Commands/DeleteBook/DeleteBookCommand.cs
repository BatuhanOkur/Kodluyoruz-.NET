using System;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;


namespace WebApi.Application.BookOperations.Commands.DeleteBook
{
    public class DeleteBookCommand
    {
        public int BookId { get; set; }
        private readonly IBookStoreDbContext _dbContext;
        public DeleteBookCommand(IBookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle()
        {
            var book = _dbContext.Books.SingleOrDefault(book => book.Id == BookId);
            if(book is null)
                throw new InvalidOperationException("Kitap bulunamadı!");
            
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }
    }
}