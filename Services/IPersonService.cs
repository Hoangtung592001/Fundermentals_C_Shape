using System;
using System.Collections.Generic;
using Models;

namespace Services
{
    public interface IPersonService
    {
        public List<Person> GetAll();

        public List<Person> GetMale();

        public Person GetOldest();

        public List<string> GetFullNames();

        public List<Person> GetPeopleByBirthYear(int year);

        public List<Person> GetPeopleByBirthYearGreaterThan(int year);

        public List<Person> GetPeopleByBirthYearLessThan(int year);

        public byte[] GetDataStream();
    }
}