using System.Reflection;

namespace Lesson11Task1
{
    public abstract class Employee
    { }

    public class EmployeeOperator : Employee, IBankEmployeeAcsesses
    {
        protected static List<string> FieldNotToSee { get; set; }
        protected static List<string> FielToChange { get; set; }

        static EmployeeOperator()
        {
            FieldNotToSee = new List<string>();
            FielToChange = new List<string>();
            FieldNotToSee.Add("Passport");
        }

        public EmployeeOperator()
        { }

        public void GetInformation(object obj)
        {
            Type t = obj.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (var prop in props)
            {
                Console.WriteLine("{0} : {1}", prop.Name,
                    AcsessToSee(prop, prop.GetValue(obj).ToString()));
            }
        }

        public void GetInformation(List<BankAccount> lst)
        {
            foreach (var account in lst) this.GetInformation(account);
        }

        protected static string AcsessToSee(PropertyInfo prop, string str)
        {
            if (FieldNotToSee.Contains(prop.Name))
            {
                string result = "";
                for (int i = 0; i < str.Length; i++) result += "*";
                return result;
            }
            return str;
        }

        public void ChangeInformation(object obj)
        {
            throw new NotImplementedException();
        }
    }

    public class EmployeeManager : EmployeeOperator
    {
        
    }
}
