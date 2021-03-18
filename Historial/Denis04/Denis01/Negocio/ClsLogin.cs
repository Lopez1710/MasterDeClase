using Denis01.DAO;
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
        ClsListaUsuarios clsUsuario = new ClsListaUsuarios();
        public int logeo(Login log)
        {
            int Estado = 0;
            for (int i=0;i<clsUsuario.user.Length;i++) 
            if (log.User.Equals(clsUsuario.user[i]) && log.Pass.Equals(clsUsuario.pass[i]))
            {
                Estado = 1;
            }
            return Estado;
        }
    }
}
