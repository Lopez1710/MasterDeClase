using Denis01.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denis01.Negocio
{
    class ClsLogin
    {
        public Boolean logeo(Login log)
        {
            if(log.User.Equals("Denis") && log.Pass.Equals("1234"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
