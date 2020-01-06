using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.NET
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public static Student GetRandomStudent()
        {
            var name = Faker.Name.FullName(NameFormats.Standard);
            return new Student
            {
                Id = Faker.RandomNumber.Next(100),
                Name = name,
                Username = Faker.Internet.UserName(),
                Email = Faker.Internet.Email(),
                Age = Faker.RandomNumber.Next(50),
                Address = Faker.Address.StreetAddress()
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                students.Add(Student.GetRandomStudent());
            }
        }
    }
}
