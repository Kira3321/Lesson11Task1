

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

            employee.GetInformation(accounts);

            employee.ChangeInformation(accounts[1]);

        }

    }
}