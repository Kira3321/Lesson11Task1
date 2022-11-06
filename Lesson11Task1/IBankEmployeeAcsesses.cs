using System.Reflection;

namespace Lesson11Task1
{
    public interface IBankEmployeeAcsesses
    {
        public void GetInformation(BankAccount obj);

        public void ChangeInformation(BankAccount obj);
    }
}
