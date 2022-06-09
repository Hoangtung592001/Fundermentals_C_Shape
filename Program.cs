using System;
using CSharpTutorialsMember;
using CSharpTutorialsEmployee;
namespace CSharpTutorials
{
    class Program
    {

        // public delegate int DelegateAdd(int x, int y);

        // public static int Add(int x, int y)
        // {
        //     return x + y;
        // }

        // public delegate List<Employee> DelegatePromote(List<Employee> employees);

        // public static List<Employee> Promote(List<Employee> employees)
        // {
        //     foreach (var employee in employees)
        //     {
        //         if (employee.ExperienceYear > 3)
        //         {
        //             employee.Salary = employee.Salary * 11 / 10;
        //         }
        //     }
        //     return employees;
        // }

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

            // Console.WriteLine("Task 1:");

            // int maxAge = 0;

            // foreach (Member member in members)
            // {
            //     if (member.Age > maxAge)
            //     {
            //         maxAge = member.Age;
            //     }
            //     if (member.Gender == "Male")
            //     {
            //         Console.WriteLine(member.Info);
            //     }
            // }

            // Console.WriteLine(maxAge);
            // Console.WriteLine("Task 2:");

            // foreach (Member member in members)
            // {
            //     if (member.Age == maxAge)
            //     {
            //         Console.WriteLine(member.Info);
            //         break;
            //     }
            // }

            // Console.WriteLine("Task 3:");
            // List<string> fullNameOfMembers = new List<string>();

            // foreach (Member member in members)
            // {
            //     Console.WriteLine(member.FullName);
            // }

            // List<Member> Age2000 = ClassifyDateYear(members, 0);
            // List<Member> AgeGreater2000 = ClassifyDateYear(members, 1);
            // List<Member> AgeLess2000 = ClassifyDateYear(members, -1);

            // Console.WriteLine("List of members have year of birth that is 2000:");
            // foreach (Member member in Age2000)
            // {
            //     Console.WriteLine(member.Info);
            // }

            // Console.WriteLine("List of members have year of birth that is greater than 2000:");
            // foreach (Member member in AgeGreater2000)
            // {
            //     Console.WriteLine(member.Info);
            // }

            // Console.WriteLine("List of members have year of birth that less than 2000:");
            // foreach (Member member in AgeLess2000)
            // {
            //     Console.WriteLine(member.Info);
            // }

            // Console.WriteLine("Task 4:");
            // int index = 0;
            // while (index < members.Count)
            // {
            //     if (members[index].BirthPlace == "Hà Nội")
            //     {
            //         Console.WriteLine(members[index].Info);
            //         break;
            //     }
            // }
            // List<Employee> employees = new List<Employee>(){
            //     new Employee("HADC", "Nguyen Hoang Tung", 5, 10),
            //     new Employee("HADC", "Nguyen Hoang Long", 3, 10),
            //     new Employee("HADC", "Nguyen Hoang Lan", 3, 10),
            //     new Employee("HADC", "Nguyen Hoang Kien", 4, 10),
            //     new Employee("HADC", "Nguyen Hoang Phong", 1, 10),
            //     new Employee("HADC", "Nguyen Hoang Vu", 6, 10)
            // };

            // var myDelegatePromote = new DelegatePromote(Promote);

            // var myResult = myDelegatePromote(employees);

            // foreach (var employee in myResult)
            // {
            //     Console.WriteLine(employee.Salary);
            // }

            // var results = from employee in employees
            //               where employee.ExperienceYear == 6 && employee.Id.Equals("HADC")
            //               select employee;

            // foreach (var result in results)
            // {
            //     Console.WriteLine(result.Name);
            // }

            // var myDelegate = new DelegateAdd(Add);
            // var myDelegate1 = new DelegateAdd(Add);
            // myDelegate.Invoke(1, 2);
            // // var myResult = myDelegate + myDelegate1;
            // Console.WriteLine(myDelegate);
            // Console.WriteLine($"{222}");

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

            // var Age2000 = (from member in members
            //               where member.DateOfBirth.Year == 2000
            //               select member);
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