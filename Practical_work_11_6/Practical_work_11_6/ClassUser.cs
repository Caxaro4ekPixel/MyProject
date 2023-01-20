using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_work_11_6
{
    internal class ClassUser
    {
        protected string firstName;
        protected string lastName;
        protected string midleName;
        protected string phone;
        protected string passportNum;

        protected ClassUser(string firstName, string lastName, string midleName, string phone, string passportNum)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.midleName = midleName;
            this.phone = phone;
            this.passportNum = passportNum;
        }

        protected string CheckIsNull(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentNullException("Поле не может быть пустым");
            return str;
        }
    }
}
