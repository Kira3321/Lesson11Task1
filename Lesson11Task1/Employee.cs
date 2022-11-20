namespace Lesson11Task1
{
    public abstract class Employee
    {

    }

    public class EmployeeOperator : Employee
    {
        protected List<string> FieldNotToSee { get; set; }
        protected List<string> FieldToChange { get; set; }

        public EmployeeOperator()
        {
            FieldNotToSee = new List<string>();
            FieldToChange = new List<string>();
            FieldNotToSee.AddRange(new[] {"Passport"});
            FieldToChange.AddRange(new[] { "PhoneNumber" });
        }

        protected void FieldReset ()
        {
            FieldNotToSee.Clear();
            FieldToChange.Clear();
        }
    }

    public class EmployeeManager : EmployeeOperator
    {

        public EmployeeManager ()
        {
            FieldReset();
            FieldToChange.AddRange(new string[]
            {
                "FirstName",
                "LastName",
                "PhoneNumber",
                "Passport"
            });
        }
    }
}
