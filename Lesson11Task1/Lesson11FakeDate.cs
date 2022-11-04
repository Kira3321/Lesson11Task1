using Bogus;

namespace Lesson11Task1
{
    public class FakeDate
    {
        public static BankAccount GenerateFakeBankAccount()
        {
            var faker = new Faker("ru");
            var name = faker.Name.FullName().Split();
            return new BankAccount(
                name[0],
                name[1],
                faker.Phone.PhoneNumber("+79#########"),
                faker.Random.Long(1000000000, 9999999999).ToString()
                );
        }
    }
}
