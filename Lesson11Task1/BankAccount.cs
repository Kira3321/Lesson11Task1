using Bogus;

namespace Lesson11Task1
{
    public class BankAccount
    {
        private static long IdCount;
        private static List<string> bankAccountsNumbers;
        public string AccountId { get; private set; }
        public string AccountNumber { get;private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Passport { get; set; }
        
        static BankAccount()
        {
            IdCount = new Random().NextInt64(5000000000, 5999999999);
            bankAccountsNumbers = new List<string>();
        }

        public BankAccount(string firstName, string lastName, string phoneNumber, string passport)
        {
            AccountId = IdCount++.ToString();
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Passport = passport;

            while (true)
            {
                AccountNumber = "4081781020000" + new Faker("ru").Random.Int(1000000, 9999999).ToString();
                if (bankAccountsNumbers.Contains(AccountNumber)) continue;
                else
                {
                    bankAccountsNumbers.Add(AccountNumber);
                    break;
                }
            }
        }
    }
}
