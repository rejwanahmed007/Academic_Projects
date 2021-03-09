using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Entity
{
    class Passenger : UserEntity
    {
        internal Passenger(int userID, string password, string name, string mobile, string email, string address, string userType) : base(userID, password, name, mobile, email, address,userType)
        {
            
        }
    }
}
