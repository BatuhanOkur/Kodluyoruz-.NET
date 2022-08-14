using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Entities;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if(context.Books.Any())
                {
                    return;
                }
                context.Authors.AddRange(
                    new Author{
                        Name = "İlber",
                        Surname = "Ortaylı",
                        BirthDate = new DateTime(1950,06,12)
                    },
                    new Author{
                        Name = "Batuhan",
                        Surname = "Okur",
                        BirthDate = new DateTime(2000,09,22)
                    },
                    new Author{
                        Name = "Süleyman",
                        Surname = "Okur",
                        BirthDate = new DateTime(1972,07,01)
                    }
                );

                context.Genres.AddRange(
                    new Genre{
                        Name = "History"
                    },
                    new Genre{
                        Name = "Science Fiction"
                    },
                    new Genre{
                        Name = "Romance"
                    }
                );

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

                context.SaveChanges();
            }
        }


    }
}