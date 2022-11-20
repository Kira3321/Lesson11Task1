

using Bogus;
using System.Reflection;

namespace Lesson11Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new BankAccount("Max", "Konoval", "+79161281011", "7878463276");
            Console.WriteLine(accounts.FirstName);
        }
    }
}