using System;
using System.Collections.Generic;

namespace CompressionCommun.Entity
{
    public class Person
    {
        private Person()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long CPF { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }

        public static List<Person> CreateList()
        {
            var persons = new List<Person>();

            for (int i = 1; i <= 10000; i++)
            {
                var person = new Person
                {
                    FirstName = $"Teste{i}",
                    LastName = $"teste{i}",
                    Email = $"Teste{i}@teste.com",
                    Telephone = 12345678,
                    CPF = 12345678901,
                    DateOfBirth = DateTime.Now
                };

                persons.Add(person);
            }

            return persons;
        }

        public static Person Create() =>
            new Person
            {
                FirstName = $"Pessoa 1",
                LastName = $"Sobrenome 1",
                Email = $"Teste@teste.com",
                Telephone = 12345678,
                CPF = 12345678901,
                DateOfBirth = DateTime.Now
            };
    }
}
