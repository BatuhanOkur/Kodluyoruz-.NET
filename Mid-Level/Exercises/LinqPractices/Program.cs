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

            //SingleOrDefault
            Console.WriteLine();
            Console.WriteLine("**********SingleOrDefault***********");
            student = _context.Students.SingleOrDefault(student => student.Name == "Süleyman");
            Console.WriteLine(student.Name + " " + student.Surname);

            //ToList
            Console.WriteLine();
            Console.WriteLine("**********ToList***********");
            var studentList = _context.Students.Where(student => student.ClassId == 11).ToList();
            Console.WriteLine(studentList.Count);

            //OrderBy
            Console.WriteLine();
            Console.WriteLine("**********OrderBy***********");
            students = _context.Students.OrderBy(x => x.StudentId).ToList();
            foreach(var st in students)
            {
                Console.WriteLine(st.StudentId + " " + st.Name + " " + st.Surname);
            }

            //OrderByDescending
            Console.WriteLine();
            Console.WriteLine("**********OrderByDescending***********");
            students = _context.Students.OrderByDescending(x => x.StudentId).ToList();
            foreach(var st in students)
            {
                Console.WriteLine(st.StudentId + " " + st.Name + " " + st.Surname);
            }

            //Anonymous Object Result
            Console.WriteLine();
            Console.WriteLine("**********Anonymous Object Result***********");

            var anonymousObject = _context.Students
                                .Where(x => x.ClassId == 11)
                                .Select(x => new{
                                    Id = x.StudentId,
                                    Fullname = x.Name + " " + x.Surname
                                });
            foreach (var obj in anonymousObject)
            {
                Console.WriteLine(obj.Id + " - " + obj.Fullname);
            }


        }
    }
}
