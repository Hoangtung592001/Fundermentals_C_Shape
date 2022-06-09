using System;
using CSharpTutorialsMember;
using CSharpTutorialsEmployee;
namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>
            {
                new Member {
                    FirstName = "Tung",
                    LastName = "Nguyen Hoang",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2000, 9, 5),
                    BirthPlace = "Ha Noi"
                },
                new Member {
                    FirstName = "Vu",
                    LastName = "Nguyen Hoang",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2000, 9, 5),
                    // BirthPlace = "Ha Noi"
                },
                new Member {
                    FirstName = "Nhat",
                    LastName = "Nguyen Hoang",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1999, 9, 5)
                },
                new Member {
                    FirstName = "Long",
                    LastName = "Nguyen Hoang",
                    Gender = "Female",
                    DateOfBirth = new DateTime(2001, 9, 5)
                }
            };

            Console.WriteLine("Task 1:");
            var maleMembers = (from member in members
                               where member.Gender.Equals("Male")
                               select member).ToList();
            maleMembers.ForEach(member =>
            {
                Console.WriteLine(member.Info);
            });

            Console.WriteLine("Task 2:");
            var oldestMember = members.MaxBy(x => x.Age);
            if (oldestMember != null)
            {
                Console.WriteLine(oldestMember.Info);
            }

            Console.WriteLine("Task 3:");
            var fullNameOnlyOfMembers = members.Select(x => x.FullName);
            foreach (var fullNameOfMember in fullNameOnlyOfMembers)
            {
                Console.WriteLine(fullNameOfMember);
            }

            Console.WriteLine("Task 4:");

            var Age2000 = members.FindAll(member => member.DateOfBirth.Year == 2000);
            var AgeHigher2000 = members.FindAll(member => member.DateOfBirth.Year > 2000);
            var AgeLess2000 = members.FindAll(member => member.DateOfBirth.Year < 2000);

            Console.WriteLine("Age is 2000");
            foreach (var member in Age2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("Age is higher than 2000");
            foreach (var member in AgeHigher2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("Age is less than 2000");
            foreach (var member in AgeLess2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("Task 5:");

            var firstPersonBornInHanoi = (from member in members
                                          where !string.IsNullOrEmpty(member.BirthPlace) &&
                                          member.BirthPlace.ToLower().Equals("ha noi")
                                          select member).FirstOrDefault();
            var firstPersonBornInHanoi1 = members.Find(member => !string.IsNullOrEmpty(member.BirthPlace) && member.BirthPlace.ToLower().Equals("ha noi"));
            if (firstPersonBornInHanoi != null)
            {
                Console.WriteLine(firstPersonBornInHanoi.Info);
            }
        }
    }
}
// SOLID, OOP
// Orm Entity Framework
// Multiple threading