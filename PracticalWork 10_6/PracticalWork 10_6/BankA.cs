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
                    this.phoneNumber = value; 
                else
                    throw new Exception("Поле <<Номер телефона>> не может быть пустым");
            } 
        }
        public string PasNumber { get { return this.pasNumber; } }

        public void GetUserInfo()
        {
            string temp = Regex.Replace(this.pasNumber, ".", "*");
            Console.WriteLine($"Имя: {this.name}\nФамилия: {this.surName}\nОтчество: {this.middleName}\nНомер телефона: {this.phoneNumber}\nНомер паспорта: {temp}");
        }
    }
}
