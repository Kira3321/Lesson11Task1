using Bogus;
using System.Reflection;

namespace Lesson11Task1
{
    public static class ViewEmployeeDate <E, A>
        where E : Employee
        where A : BankAccount
    {
        //public void ChangeInformation(BankAccount obj)
        //{
        //    Type type = obj.GetType();
        //    var props = type.GetProperties();
        //    for (int i = 0; i < props.Length; i++)
        //    {
        //        var prop = props[i];
        //        if (FielToChange.Contains(prop.Name))
        //        {
        //            Console.WriteLine($"Нужно изменить {prop.Name}?\nДа/Нет");
        //            string? userInput = Console.ReadLine();
        //            if (userInput == "Да")
        //            {
        //                while (true)
        //                {
        //                    Console.WriteLine($"Введите новое значение в примерном виде {prop.GetValue(obj)}");
        //                    userInput = Console.ReadLine();
        //                    if (string.IsNullOrWhiteSpace(userInput))
        //                    {
        //                        Console.WriteLine("Пустое значение нельзя установить");
        //                        continue;
        //                    }
        //                    prop.SetValue(obj, userInput);
        //                    Console.WriteLine($"Установленно новое значение: {prop.GetValue(obj)}");
        //                    break;
        //                }
        //            }
        //            else Console.WriteLine("Пользователь отказался от ввода. Значение не будет изменено");
        //        }
        //        else Console.WriteLine($"Поле {prop.Name} недоступно для редактирования");
        //    }
        //}

        //public void GetInformation(BankAccount account)
        //{
        //    Type t = account.GetType();
        //    PropertyInfo[] props = t.GetProperties();
        //    foreach (var prop in props)
        //    {
        //        Console.WriteLine("{0} : {1}", prop.Name,
        //            AcsessToSee(prop, prop.GetValue(account).ToString()));
        //    }
        //}

        //public void GetInformation(List<BankAccount> lst)
        //{
        //    foreach (var account in lst) this.GetInformation(account);
        //}

        //protected string AcsessToSee(PropertyInfo prop, string str)
        //{
        //    if (FieldNotToSee.Contains(prop.Name))
        //    {
        //        string result = "";
        //        for (int i = 0; i < str.Length; i++) result += "*";
        //        return result;
        //    }
        //    return str;
        //}
    }

    file class FakeDate
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
