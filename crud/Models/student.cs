using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace crud.Models
{
    public class student
    {
        public int Id { get; set; }


        //[Required]
        //[MinLength(5)]
        public string Name { get; set; }

        //[Required]
        public string Address { get; set; }

        //[Required]
        //[EmailAddress]
        public string Email { get; set; }

        public int Age { get; set; }

        public List<student> StudentList { get; set; }


        public bool Checked { get; set; }
        public int GetAge()
        {
            return 0;
        }
        //View Model:
        //Domain model: Logic
        //Entity


        public List<student> GetStudentList()
        {
            var list = new List<student>();
            var student1 = new student
            {
                Id = 1,
                Name = "Gaurav",
                Address = "KTM",
                Age = 23
            };
            list.Add(student1);

            var student2 = new student
            {
                Id = 2,
                Name = "Sandip",
                Address = "PKR",
                Age = 22
            };
            list.Add(student2);
            var student3 = new student
            {
                Id = 3,
                Name = "Mandip",
                Address = "BRT",
                Age = 24
            };
            list.Add(student3);

            return list;

        }
    }
}
