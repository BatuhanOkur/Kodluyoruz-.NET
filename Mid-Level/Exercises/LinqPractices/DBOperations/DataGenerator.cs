using System.Linq;

namespace LinqPractices.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            using(var context = new LinqDbContext())
            {
                if(context.Students.Any())
                {
                    return;
                }
                context.Students.AddRange(
                    new Student(){
                        StudentId = 1,
                        Name = "Serkan",
                        Surname = "Okur",
                        ClassId = 11
                    },
                    new Student(){
                        StudentId = 2,
                        Name = "Gül",
                        Surname = "Okur",
                        ClassId = 12
                    },
                    new Student(){
                        StudentId = 3,
                        Name = "Süleyman",
                        Surname = "Okur",
                        ClassId = 10
                    },
                    new Student(){
                        StudentId = 4,
                        Name = "Batuhan",
                        Surname = "Okur",
                        ClassId = 9
                    }
                );
                context.SaveChanges();
            }
        }
    }
}