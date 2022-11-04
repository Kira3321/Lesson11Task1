namespace Lesson11Task1
{
    internal class BankAccount
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }

        public BankAccount(string firstName, string lastName, string phoneNumber, string passport)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Passport = passport;
        }
    }
}
