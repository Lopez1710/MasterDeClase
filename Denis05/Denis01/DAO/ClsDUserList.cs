using Denis01.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denis01.DAO
{
    class ClsDUserList
    {
        public List<UserList> cargardatosUserLis()
        {
            List<UserList> lista;
            using (programacionEntities db = new programacionEntities())
            {
                 lista = db.UserList.ToList();

            }

            return lista;
        }

        public void SaveDatoUser(UserList user)
        {

            using (programacionEntities db = new programacionEntities())
            {

                UserList userList = new UserList();
                try
                {
                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido ;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;

                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Se ha agregado el usuario " + user.NombreUsuario);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        public void DeleteUser (int ID)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    int eliminar = Convert.ToInt32(ID);
                    UserList userList = db.UserList.Where(x => x.id == eliminar).Select(x => x).FirstOrDefault();

                    //
                    //userList = db.UserList.Find(eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

                    MessageBox.Show("Se ha Eliminado al Usuario con Id = " + ID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);


            }
        }

        public void Update(UserList user)
        {
            using (programacionEntities db = new programacionEntities())
            {

                int Update = Convert.ToInt32(user.id);
                UserList userList = db.UserList.Where(x => x.id == Update).Select(x => x).FirstOrDefault();
                userList.NombreUsuario = user.NombreUsuario;
                userList.Apellido = user.Apellido;
                userList.Edad = user.Edad;
                userList.Pass = user.Pass;

                db.SaveChanges();


            }
        }
 
    }
}
