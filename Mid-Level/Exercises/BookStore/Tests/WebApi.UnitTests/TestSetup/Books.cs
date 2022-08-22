using System;
using WebApi.DBOperations;
using WebApi.Entities;

namespace TestSetup
{
    public static class Books
    {
        public static void AddBooks(this BookStoreDbContext context)
        {
            context.Books.AddRange(
                    new Book{
                        //Id = 1,
                        Title = "Türklerin Tarihi",
                        GenreId = 1, //history
                        PageCount = 200,
                        AuthorId = 1,
                        PublishDate = new DateTime(2001,06,12)
                    },
                    new Book{
                        //Id = 2,
                        Title = "Herland",
                        GenreId = 2, //Science Fic
                        PageCount = 250,
                        AuthorId = 2,
                        PublishDate = new DateTime(2010,05,23)
                    },
                    new Book{
                        //Id = 3,
                        Title = "Dune",
                        GenreId = 2, //Science Fic
                        PageCount = 250,
                        AuthorId = 3,
                        PublishDate = new DateTime(2018,04,13)
                    }
                );
        }
    }
}