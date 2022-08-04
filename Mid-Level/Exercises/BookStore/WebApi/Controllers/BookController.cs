using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.DBOperations;

namespace WebApi.AddControllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController : ControllerBase
    {
        private readonly BookStoreDbContext _context;
        public BookController(BookStoreDbContext context)
        {
            _context = context;
        }
        // private static List<Book> BookList = new List<Book>(){
        //     new Book{
        //         Id = 1,
        //         Title = "Türklerin Tarihi",
        //         GenreId = 1, //history
        //         PageCount = 200,
        //         PublishDate = new DateTime(2001,06,12)
        //     },
        //     new Book{
        //         Id = 2,
        //         Title = "Herland",
        //         GenreId = 2, //Science Fic
        //         PageCount = 250,
        //         PublishDate = new DateTime(2010,05,23)
        //     },
        //     new Book{
        //         Id = 3,
        //         Title = "Dune",
        //         GenreId = 2, //Science Fic
        //         PageCount = 250,
        //         PublishDate = new DateTime(2018,04,13)
        //     }
        // };

        [HttpGet]
        public List<Book> GetBooks()
        {
            var booklist = _context.Books.OrderBy(book=> book.Id).ToList<Book>();
            return booklist;
        }

        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            var book = _context.Books.Where(book=> book.Id == id).SingleOrDefault();
            return book; 
        }

        // [HttpGet]
        // public Book Get([FromQuery] string id)
        // {
        //     var book = BookList.Where(book=> book.Id == Convert.ToInt32(id)).SingleOrDefault();
        //     return book; 
        // }

        //POST
        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            var book = _context.Books.SingleOrDefault(book => book.Title == newBook.Title);
            if(book is not null)
                return  BadRequest();

            _context.Books.Add(newBook);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = _context.Books.SingleOrDefault(book => book.Id == id);
            if(book is null)
                return BadRequest();
            
            book.GenreId = updatedBook.GenreId != default ? updatedBook.GenreId : book.GenreId;
            book.PageCount = updatedBook.PageCount != default ? updatedBook.PageCount : book.PageCount;
            book.PublishDate = updatedBook.PublishDate != default ? updatedBook.PublishDate : book.PublishDate;
            book.Title = updatedBook.Title != default ? updatedBook.Title : book.Title;
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _context.Books.SingleOrDefault(book => book.Id == id);
            if(book is null)
                return BadRequest();
            
            _context.Books.Remove(book);
            _context.SaveChanges();
            return Ok();
        }

    }
}