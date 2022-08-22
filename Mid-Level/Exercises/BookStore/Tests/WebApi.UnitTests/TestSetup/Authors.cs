using System;
using WebApi.DBOperations;
using WebApi.Entities;

namespace TestSetup
{
    public static class Authors
    {
        public static void AddAuthors(this BookStoreDbContext context)
        {
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
        }
    }
}