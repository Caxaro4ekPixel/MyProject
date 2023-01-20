using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practical_work_11_6
{
    internal class Consultant : ClassUser
    {
        public Consultant(string firstName, string lastName, string midleName, string phone, string passportNum) : base(firstName, lastName, midleName, phone, passportNum)
        {
        }

        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public string MidleName { get { return this.midleName; } }
        public string Phone { get { return this.phone; } set { this.phone = CheckIsNull(value); } }
        public string PassportNum { get { return Regex.Replace(this.passportNum, ".", "*"); } }


    }
}
