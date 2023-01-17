using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticalWork_10_6
{
    internal class BankB : Person
    {
        public BankB(string lastName, string firstName, string midleName, string phoneNumber, string passportNum) : base(lastName, firstName, midleName, phoneNumber, passportNum)
        {
        }

        public void ShowInfoUser()
        {
            Console.WriteLine($"Имя: {FirstName}\n" +
                $"Фамилия: {LastName}\n" +
                $"Отчество: {MidleName}\n" +
                $"Номер телефона: {PhoneNumber}\n" +
                $"Номер паспорта: {PassportNum}\n" +
                $"Дата изменения: {DateEdit}\n" +
                $"Тип изменения: {DataChangedType}\n" +
                $"Комментарий: {DataChanged}\n" +
                $"Кто изменил: {DataChangedUser}");
        }
    }
}
