using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALayer;
using BELayer;

namespace BALayer
{
    public class BAL
    {
        BEL beObj = new BEL();
        DAL daObj = new DAL();

        public int userDetails(BEL obj)
        {
           return daObj.userDetailsInsertMethod(obj);
        }

        public bool credentials(BEL obj)
        {
            return daObj.login(obj);
        }
    }
}
