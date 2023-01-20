using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_work_11_6
{
    internal class Maneger : ClassUser
    {
        public Maneger(string firstName, string lastName, string midleName, string phone, string passportNum) : base(firstName, lastName, midleName, phone, passportNum)
        {
        }

        public string FirstName { get { return this.firstName; } set { this.firstName = CheckIsNull(value); } }
        public string LastName { get { return this.lastName; } set { this.lastName = CheckIsNull(value); } }
        public string MidleName { get { return this.midleName; } set { this.midleName = CheckIsNull(value); } }
        public string Phone { get { return this.phone; } set { this.phone = CheckIsNull(value); } }
        public string PassportNum { get { return this.passportNum; } set { this.passportNum = CheckIsNull(value); } }
    }
}
