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
            
            //
        }
    }
}
