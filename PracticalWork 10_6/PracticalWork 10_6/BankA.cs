using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticalWork_10_6
{
    internal class BankA
    {

        private string surName;
        private string name;
        private string middleName;
        private string phoneNumber;
        private string pasNumber;
        private DateTime dataEdit;
        private string editComment;
        private string typeEdit;
        private string userEdit;
        public BankA(string surName, string name, string middleName, string phoneNumber, string pasNumber)
        {
            this.surName = surName;
            this.name = name;
            this.middleName = middleName;
            this.phoneNumber = phoneNumber;
            this.pasNumber = pasNumber;
        }

        public string SurName { get { return this.surName; } }
        public string Name { get { return this.name; } }
        public string MiddleName { get { return this.middleName; } }
        public string PhoneNumber 
        { 
            get 
            { 
                return this.phoneNumber; 
            } 
            set { 
                if (value != "")
                {
                    this.phoneNumber = value;
                    this.dataEdit = DateTime.Now;
                    this.typeEdit = "Изменение номера";
                    this.editComment = $"(изменено с {this.phoneNumber} на {value})";
                    this.userEdit = "Менеджер";
                }
                else
                    throw new Exception("Поле <<Номер телефона>> не может быть пустым");
            } 
        }
        public string PasNumber { get { return this.pasNumber; } }

        public void GetUserInfo()
        {
            string temp = Regex.Replace(this.pasNumber, ".", "*");
            Console.WriteLine($"Имя: {this.name}\n" +
                $"Фамилия: {this.surName}\n" +
                $"Отчество: {this.middleName}\n" +
                $"Номер телефона: {this.phoneNumber}\n" +
                $"Номер паспорта: {temp}\n" +
                $"Дата изменения: {this.dataEdit}\n" +
                $"Тип изменения: {this.typeEdit}\n" +
                $"Комментприй: {this.editComment}\n" +
                $"Кто изменил: {this.userEdit}");
        }
    }
}
