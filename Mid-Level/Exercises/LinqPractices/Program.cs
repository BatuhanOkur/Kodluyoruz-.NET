using System;
using System.Linq;
using LinqPractices.DBOperations;

namespace LinqPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>();

            //Find()
            Console.WriteLine("*****Find******");
            var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();
            student = _context.Students.Find(1);
            Console.WriteLine(student.Name + " " + student.Surname);
            
            //FirstOrDefault
            Console.WriteLine();
            Console.WriteLine("**********FirstOrDefault***********");
            student = _context.Students.Where(student => student.Name == "Batuhan").FirstOrDefault();
            Console.WriteLine(student.Name + " " + student.Surname);

            student = _context.Students.FirstOrDefault(student => student.Name == "Batuhan");
            Console.WriteLine(student.Name + " " + student.Surname);

        }
    }
}
