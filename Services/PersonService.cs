using System;
using Models;
using CsvHelper;
using System.Globalization;

namespace Services
{
    public class PersonService : IPersonService
    {
        private static List<Person> _members = new List<Person>
        {
            new Person {
                FirstName = "Tung",
                LastName = "Nguyen Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 9, 5),
                BirthPlace = "Ha Noi"
            },
            new Person {
                FirstName = "Vu",
                LastName = "Nguyen Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 9, 5),
                // BirthPlace = "Ha Noi"
            },
            new Person {
                FirstName = "Nhat",
                LastName = "Nguyen Hoang",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 9, 5)
            },
            new Person {
                FirstName = "Long",
                LastName = "Nguyen Hoang",
                Gender = "Female",
                DateOfBirth = new DateTime(2001, 9, 5)
            }
        };

        public List<Person> GetAll()
        {
            return _members;
        }

        public List<string> GetFullNames()
        {
            var fullNames = _members.Select(member => member.FirstName + member.LastName).ToList();
            return fullNames;
        }

        public List<Person> GetMale()
        {
            List<Person> malePeople = _members.Where(member => member.Gender.Equals("Male")).ToList();
            return malePeople;
        }

        public Person GetOldest()
        {
            Person oldestPerson = _members.MaxBy(member => member.Age);
            return oldestPerson != null ? oldestPerson : new Person();
        }

        public List<Person> GetPeopleByBirthYear(int year)
        {
            List<Person> results = _members.FindAll(member => member.DateOfBirth.Year == 2000);
            return results;
        }

        public List<Person> GetPeopleByBirthYearGreaterThan(int year)
        {
            List<Person> results = _members.FindAll(member => member.DateOfBirth.Year > 2000);
            return results;
        }

        public List<Person> GetPeopleByBirthYearLessThan(int year)
        {
            List<Person> results = _members.FindAll(member => member.DateOfBirth.Year < 2000);
            return results;
        }

        public byte[] GetDataStream()
        {
            using (var memoryStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memoryStream))
            using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.CurrentCulture))
            {
                csvWriter.WriteRecords(_members);
                streamWriter.Flush();
                return memoryStream.ToArray();
            }
        }

    }
}