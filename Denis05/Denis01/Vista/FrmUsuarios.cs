using Denis01.DAO;
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
            ClsDUserList clsDUser = new ClsDUserList();
            List < UserList> lista = clsDUser.cargardatosUserLis();

            foreach (var iteracion in lista)
            {

                DtgUsuarios.Rows.Add(iteracion.id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtId.Text.Equals(""))
            {
                ClsDUserList clsD = new ClsDUserList();
                UserList userList = new UserList();
                userList.NombreUsuario = TxtNombre.Text;
                userList.Apellido = TxtApellido.Text;
                userList.Edad = Convert.ToInt32(TxtEdad.Text);
                userList.Pass = TxtPass.Text;
                clsD.SaveDatoUser(userList);
            }
            else
            {
                ClsDUserList clsD = new ClsDUserList();
                UserList userList = new UserList();
                userList.id = Convert.ToInt32(TxtId.Text);
                userList.NombreUsuario = TxtNombre.Text;
                userList.Apellido = TxtApellido.Text;
                userList.Edad = Convert.ToInt32(TxtEdad.Text);
                userList.Pass = TxtPass.Text;
                clsD.Update(userList);
            }
                carga();
                Clear();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsDUserList clsDUser = new ClsDUserList();
            clsDUser.DeleteUser(Convert.ToInt32(TxtId.Text));
            
                
            carga();
            Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
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
