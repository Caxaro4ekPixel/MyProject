using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticalWork_10_6
{
    internal class Person
    {
        private string lastName;
        private string firstName;
        private string midleName;
        private string phoneNumber;
        private string passportNum;
        private DateTime dateEdit;
        private string dataChanged;
        private string dataChangedType;
        private string dataChangedUser;

        public Person(string lastName, string firstName, string midleName, string phoneNumber, string passportNum)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.midleName = midleName;
            this.phoneNumber = phoneNumber;
            this.passportNum = passportNum;
        }

        public string LastName { get { return this.lastName; } }
        public string FirstName { get { return this.firstName; } }
        public string MidleName { get { return this.midleName; } }
        public string PhoneNumber { 
            get 
            { 
                return this.phoneNumber; 
            } 
            set 
            { 
                if (value != "") 
                    this.phoneNumber = value; 
                else throw new Exception("Это поле <<Номер телефона>> не может быть пустым"); 
            } 
        }
        public string PassportNum { get { return this.passportNum; } }
        public DateTime DateEdit { get { return this.dateEdit; } set { this.dateEdit = DateTime.Now; } }
        public string DataChanged { get { return this.dataChanged; } set { this.dataChanged = value; } }
        public string DataChangedType { get { return this.dataChangedType; } set { this.dataChangedType = value; } }
        public string DataChangedUser { get { return this.dataChangedUser; } set { this.dataChangedUser = value;} }
    }
}
