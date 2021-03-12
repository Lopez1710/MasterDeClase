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

        void Clear()
        {
            TxtId.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear(); ;
            TxtEdad.Clear();
            TxtPass.Clear();
        }



        void carga()
        {
            DtgUsuarios.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var lista = db.UserList.ToList();


                foreach (var iteracion in lista)
                {

                    DtgUsuarios.Rows.Add(iteracion.id,iteracion.NombreUsuario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);

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
                Clear();

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
            Clear();
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
            Clear();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

            carga();
        }

        private void DtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id = DtgUsuarios.CurrentRow.Cells[0].Value.ToString();
            TxtId.Text = Id;

            string Nombre = DtgUsuarios.CurrentRow.Cells[1].Value.ToString();
            TxtNombre.Text = Nombre;

            string Apellido = DtgUsuarios.CurrentRow.Cells[2].Value.ToString();
            TxtApellido.Text = Apellido;

            string Edad = DtgUsuarios.CurrentRow.Cells[3].Value.ToString();
            TxtEdad.Text = Edad;

            string Pass = DtgUsuarios.CurrentRow.Cells[4].Value.ToString();
            TxtPass.Text = Pass;
        }
    }
}
