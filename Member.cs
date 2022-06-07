namespace CSharpTutorialsMember
{
    class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get { return DateTime.Now.Year - this.DateOfBirth.Year; } }
        public bool IsGraduated { get; set; }
        public string Info
        {
            get
            {
                return string.Format("First Name:{0}\r\nLast Name: {1} \r\nGender:{2}", this.FirstName, this.LastName, this.Gender);
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }
    }
}