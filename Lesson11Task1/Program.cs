

using Bogus;
using System.Reflection;

namespace Lesson11Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<BankAccount>();
            for (int i = 0; i < 100; i++) accounts.Add(FakeDate.GenerateFakeBankAccount());

            var employee = new EmployeeOperator();

            foreach (var item in accounts) employee.GetInformation(item);

            employee.GetInformation(accounts);

        }

    }
}