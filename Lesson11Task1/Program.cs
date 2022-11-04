

using Bogus;

namespace Lesson11Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<BankAccount>();
            for (int i = 0; i < 1000; i++) accounts.Add(FakeDate.GenerateFakeBankAccount());
            foreach (var item in accounts) Console.WriteLine(item);
        }


    }
}