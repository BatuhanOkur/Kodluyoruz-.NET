using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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

                context.Books.AddRange(
                    new Book{
                        Id = 1,
                        Title = "Türklerin Tarihi",
                        GenreId = 1, //history
                        PageCount = 200,
                        PublishDate = new DateTime(2001,06,12)
                    },
                    new Book{
                        Id = 2,
                        Title = "Herland",
                        GenreId = 2, //Science Fic
                        PageCount = 250,
                        PublishDate = new DateTime(2010,05,23)
                    },
                    new Book{
                        Id = 3,
                        Title = "Dune",
                        GenreId = 2, //Science Fic
                        PageCount = 250,
                        PublishDate = new DateTime(2018,04,13)
                    }
                );

                context.SaveChanges();
            }
        }


    }
}