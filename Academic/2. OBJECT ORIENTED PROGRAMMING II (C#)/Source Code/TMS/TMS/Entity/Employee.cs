using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Entity
{
    class Employee : UserEntity
    {
        internal Employee(int userID, string password, string name, string mobile, string email, string address, string userType,string designation,int salary,string hireDate,double commission) : base(userID, password, name, mobile, email, address, userType)
        {
            this.Designation = designation;
            this.Salary = salary;
            this.HireDate = hireDate;
            this.Commission = commission;
        }
        internal string Designation { set; get; }
        internal int Salary { set; get; }
        internal string HireDate { set; get; }
        internal double Commission { set; get; }
    }
}
