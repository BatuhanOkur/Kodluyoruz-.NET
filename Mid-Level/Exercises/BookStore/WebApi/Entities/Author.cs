using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Author(int id, string name, string surname, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return new string(Name + " " + Surname + " - DT: " + BirthDate.Date);
        }
    }
}