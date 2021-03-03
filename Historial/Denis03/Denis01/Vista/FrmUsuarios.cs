using Denis01.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denis01.Vista
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (programacionEntities db = new programacionEntities()) {

                UserList userList = new UserList();
                try
                {
                    userList.NombreUsuario = TxtNombre.Text;
                    userList.Apellido = TxtApellido.Text;
                    userList.Edad = Convert.ToInt32(TxtEdad.Text);
                    userList.Pass = TxtPass.Text;

                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Se ha agregado el usuario " + TxtNombre.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: "+ex);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
                try
                {
                using (programacionEntities db = new programacionEntities()) {

                    UserList userList = new UserList();

                    int eliminar = Convert.ToInt32(TxtId.Text);
                    userList = db.UserList.Find(eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

                    MessageBox.Show("Se ha Eliminado al Usuario con Id = " + TxtId.Text);
                }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);


                } 
            
        }
    }
}
