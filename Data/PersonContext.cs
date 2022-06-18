using WebAPI.Entities;

namespace WebAPI.Data
{
    public static class PersonContext
    {
        public static List<Person> people = new List<Person>(){
            new Person("Tung", "Nguyen Hoang", new DateTime(2001, 9, 5), "Male", "Bac Ninh"),
            new Person("Long", "Nguyen Hoang", new DateTime(1985, 9, 5), "FeMale", "Ha Noi"),
            new Person("Thai", "Nguyen Hoang", new DateTime(2011, 9, 5), "FeMale", "Hai Phong"),
            new Person("Lan", "Nguyen Hoang", new DateTime(1999, 9, 5), "Male", "Quang Nam")
        };
    }
}