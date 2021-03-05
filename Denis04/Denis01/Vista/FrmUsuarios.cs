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
        void carga()
        {
            dataGridView1.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var lista = db.UserList.ToList();


                foreach (var iteracion in lista)
                {

                    dataGridView1.Rows.Add(iteracion.id,iteracion.NombreUsuario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);

                }


            }
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
                carga();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
                try
                {
                using (programacionEntities db = new programacionEntities()) {

                    int eliminar = Convert.ToInt32(TxtId.Text);
                    UserList userList = db.UserList.Where(x => x.id == eliminar).Select(x => x).FirstOrDefault();

                    //
                    //userList = db.UserList.Find(eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

                    MessageBox.Show("Se ha Eliminado al Usuario con Id = " + TxtId.Text);
                }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);


                }
            carga();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (programacionEntities db = new programacionEntities())
            {

                int Update = Convert.ToInt32(TxtId.Text);
                UserList userList = db.UserList.Where(x => x.id == Update).Select(x => x).FirstOrDefault();
                userList.NombreUsuario = TxtNombre.Text;
                userList.Apellido = TxtApellido.Text;
                userList.Edad = Convert.ToInt32(TxtEdad.Text);
                userList.Pass = TxtPass.Text;

                db.SaveChanges();


            }
            carga();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

            carga();
        }
    }
}
