

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

            var employeeOperator = new EmployeeOperator();
            var employeeMangaer = new EmployeeManager();

            employeeOperator.GetInformation(accounts[0]);

            employeeOperator.ChangeInformation(accounts[0]);

            employeeMangaer.GetInformation(accounts[0]);
        }

    }
}