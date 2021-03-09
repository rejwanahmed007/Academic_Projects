using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Data;
using TMS.Entity;
using TMS.Framework;
using TMS.Repository;

namespace TMS
{
    public class DelegatesCollection
    {
        internal delegate void GridDelegate(UserEntity userinfo);
    }
}
