using System;
using CSharpTutorialsMember;

namespace CSharpTutorials
{
    class Program
    {

        static List<Member> ClassifyDateYear(List<Member> members, int ageClass)
        {
            List<Member> results = new List<Member>();
            switch (ageClass)
            {
                case 0:
                    foreach (Member member in members)
                    {
                        if (member.DateOfBirth.Year == 2000)
                        {
                            results.Add(member);
                        }
                    }
                    break;
                case -1:
                    foreach (Member member in members)
                    {
                        if (member.DateOfBirth.Year < 2000)
                        {
                            results.Add(member);
                        }
                    }
                    break;
                default:
                    foreach (Member member in members)
                    {
                        if (member.DateOfBirth.Year > 2000)
                        {
                            results.Add(member);
                        }
                    }

                    break;
            }

            return results;
        }

        static void Main(string[] args)
        {
            List<Member> members = new List<Member>
            {
                new Member {
                    FirstName = "Tung",
                    LastName = "Nguyen Hoang",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2000, 9, 5),
                    BirthPlace = "Hà Nội"
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
                    Gender = "Male",
                    DateOfBirth = new DateTime(2001, 9, 5)
                }
            };

            Console.WriteLine("Task 1:");
            int maxAge = 0;

            foreach (Member member in members)
            {
                if (member.Age > maxAge)
                {
                    maxAge = member.Age;
                }
                if (member.Gender == "Male")
                {
                    Console.WriteLine(member.Info);
                }
            }

            Console.WriteLine(maxAge);
            Console.WriteLine("Task 2:");

            foreach (Member member in members)
            {
                if (member.Age == maxAge)
                {
                    Console.WriteLine(member.Info);
                    break;
                }
            }

            Console.WriteLine("Task 3:");
            List<string> fullNameOfMembers = new List<string>();

            foreach (Member member in members)
            {
                Console.WriteLine(member.FullName);
            }

            List<Member> Age2000 = ClassifyDateYear(members, 0);
            List<Member> AgeGreater2000 = ClassifyDateYear(members, 1);
            List<Member> AgeLess2000 = ClassifyDateYear(members, -1);

            Console.WriteLine("List of members have year of birth that is 2000:");
            foreach (Member member in Age2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("List of members have year of birth that is greater than 2000:");
            foreach (Member member in AgeGreater2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("List of members have year of birth that less than 2000:");
            foreach (Member member in AgeLess2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("Task 4:");
            int index = 0;
            while (index < members.Count)
            {
                if (members[index].BirthPlace == "Hà Nội")
                {
                    Console.WriteLine(members[index].Info);
                    break;
                }
            }
        }
    }
}
