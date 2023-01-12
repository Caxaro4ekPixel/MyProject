using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticalWork_10_6
{
    internal class BankB : BankA
    {
        private string address;
        private DateTime dataEdit;
        private string editComment;
        private string typeEdit;
        private string userEdit;
        public string Address
        {
            get { return this.address; }
            set 
            {
                if (value != "")
                {
                    this.address = value;
                    this.dataEdit = DateTime.Now;
                    this.typeEdit = "Изменение адреса";
                    this.editComment = $"(изменено с {this.address} на {value})";
                    this.userEdit = "Консультант";
                }
                else
                    throw new Exception("Поле <<Адрес>> не может быть пустым");
            }
        }
        public BankB(string surName, string name, string middleName, string phoneNumber, string pasNumber, string address) : base(surName, name, middleName, phoneNumber, pasNumber)
        {
            this.address = address;
        }

        public void GetUserInfoB()
        {
            string temp = Regex.Replace(this.PasNumber, ".", "*");
            Console.WriteLine(
                $"Имя: {this.Name}\n" +
                $"Фамилия: {this.SurName}\n" +
                $"Отчество: {this.MiddleName}\n" +
                $"Номер телефона: {this.PhoneNumber}\n" +
                $"Номер паспорта: {temp}\n" +
                $"Адрес: {this.address}" +
                $"Дата изменения: {this.dataEdit}\n" +
                $"Тип изменения: {this.typeEdit}\n" +
                $"Комментприй: {this.editComment}\n" +
                $"Кто изменил: {this.userEdit}");
        }
    }
}
