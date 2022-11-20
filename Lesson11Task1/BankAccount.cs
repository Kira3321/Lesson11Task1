using Bogus;
using System.ComponentModel;
using System.Reflection;

namespace Lesson11Task1
{
    public class BankAccount
    {
        private static long IdCount;
        private static List<string> bankAccountsNumbers;
        private List<BankAccountLogs> _logs;
        private string? firstName;

        public string AccountId { get; init; }
        public string? AccountNumber { get; init; }
        public string? FirstName { get => firstName; set => firstName = $"{value}{MethodBase.GetCurrentMethod().Name}"; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Passport { get; set; }


        static BankAccount()
        {
            IdCount = new Random().NextInt64(5000000000, 5999999999);
            bankAccountsNumbers = new List<string>();
        }

        public BankAccount(string firstName, string lastName, string phoneNumber, string passport)
        {
            _logs = new List<BankAccountLogs>();
            AccountId = IdCount++.ToString();
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Passport = passport;
            AccountNumber = CreateAccountNumber();
        }

        private string CreateAccountNumber()
        {
            while (true)
            {
                var accountNumber = "4081781020000" + new Faker("ru").Random.Int(1000000, 9999999).ToString();
                if (bankAccountsNumbers.Contains(accountNumber)) continue;
                else
                {
                    return accountNumber;
                }
            }
        }

        public void Logs()
        {
            foreach (var log in _logs) Console.WriteLine(log);
        }


    }

    internal class BankAccountLogs
    {
        private string _changedField;
        private string? _editor;
        private string? _oldValue;
        private string? _newValue;
        private DateTime? _changeTime;
        private string _modeOperation;

        public BankAccountLogs(string changedField, string? newValue, string? oldValue, string editor = "SADMIN")
        {
            _changedField = changedField;
            _oldValue = oldValue;
            _newValue = newValue;
            _editor = editor;
            _changeTime = DateTime.Now;
            _modeOperation = _oldValue is null ? "Create" : "Update";

        }

        public override string ToString()
        {
            return $"""
                Изменяемое поле - {_changedField}
                Время изменения - {_changeTime}
                Кто меняет - {_editor}
                Тип операции - {_modeOperation}
                Старое значение - {_oldValue}
                Новое значение - {_newValue}
                """;
        }
    }
}
