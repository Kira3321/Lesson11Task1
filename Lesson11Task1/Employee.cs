﻿using System.Reflection;

namespace Lesson11Task1
{
    public abstract class Employee
    { }

    public class EmployeeOperator : Employee, IBankEmployeeAcsesses
    {
        protected List<string> FieldNotToSee { get; set; }
        protected List<string> FielToChange { get; set; }

        public EmployeeOperator()
        {
            FieldNotToSee = new List<string>();
            FielToChange = new List<string>();
            FieldNotToSee.Add("Passport");
            FielToChange.Add("PhoneNumber");
        }

        public void GetInformation(BankAccount obj)
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

        protected string AcsessToSee(PropertyInfo prop, string str)
        {
            if (FieldNotToSee.Contains(prop.Name))
            {
                string result = "";
                for (int i = 0; i < str.Length; i++) result += "*";
                return result;
            }
            return str;
        }

        public void ChangeInformation(BankAccount obj)
        {
            Type type = obj.GetType();
            var props = type.GetProperties();
            for (int i = 0; i < props.Length; i++)
            {
                var prop = props[i];
                if  (FielToChange.Contains(prop.Name))
                {
                    Console.WriteLine($"Нужно изменить {prop.Name}?\nДа/Нет");
                    string? userInput = Console.ReadLine();
                    if (userInput == "Да")
                    {
                        while (true)
                        {
                            Console.WriteLine($"Введите новое значение в примерном виде {prop.GetValue(obj)}");
                            userInput = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(userInput))
                            {
                                Console.WriteLine("Пустое значение нельзя установить");
                                continue;
                            }    
                            prop.SetValue(obj, userInput);
                            Console.WriteLine($"Установленно новое значение: {prop.GetValue(obj)}") ;
                            break;
                        }
                    }
                    else Console.WriteLine("Пользователь отказался от ввода. Значение не будет изменено");
                }
                else Console.WriteLine($"Поле {prop.Name} недоступно для редактирования");
            }
        }
    }

    public class EmployeeManager : EmployeeOperator
    {
        public EmployeeManager ()
        {
            FieldNotToSee = new List<string>();
            FielToChange = new List<string>();
            FielToChange.AddRange(new string[]
            {
                "FirstName",
                "LastName",
                "PhoneNumber",
                "Passport"
            });
        }
    }
}
