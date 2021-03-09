using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Entity
{
    class UserEntity
    {
        internal UserEntity(int userID,string password,string name,string mobile,string email,string address,string userType)
        {
            this.UserID = userID;
            this.Password = password;
            this.Name = name;
            this.Mobile = mobile;
            this.Email = email;
            this.Address = address;
            this.UserType = userType;
        }
        internal int UserID { set; get; }
        internal string Password { set; get; }
        internal string Name { set; get; }
        internal string Mobile { set; get; }
        internal string Email { set; get; }
        internal string Address { set; get; }
        internal string UserType { set; get; }
         
    }
}
