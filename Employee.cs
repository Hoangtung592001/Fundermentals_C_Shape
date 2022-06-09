namespace CSharpTutorialsEmployee
{
    class Employee
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int ExperienceYear { get; set; }

        public int Salary { get; set; }

        public Employee(string Id_, string Name_, int ExperienceYear_, int Salary_)
        {
            this.Id = Id_;
            this.Name = Name_;
            this.ExperienceYear = ExperienceYear_;
            this.Salary = Salary_;
        }
    }
}