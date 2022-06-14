using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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

        public void CreateNewPerson(Person person);

        public void EditInfoMember([Bind("FirstName,LastName,Gender,DateOfBirth,PhoneNumber,BirthPlace")] Person person);

        public void DeleteInfoMember(int id);

        public byte[] GetDataStream();

        public Person GetOne(int id);
    }
}