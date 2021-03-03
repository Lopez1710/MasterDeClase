using Denis01.DAO;
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
    public partial class FrmListaDeUsuarios : Form
    {
        public FrmListaDeUsuarios()
        {
            InitializeComponent();
        }

        private void FrmListaDeUsuarios_Load(object sender, EventArgs e)
        {
            ClsListaUsuarios clsUsuario = new ClsListaUsuarios();

            foreach(var iteracion in clsUsuario.user)
            {
                dataGridView1.Rows.Add(iteracion.ToString());
            }

            foreach(var iteracion in clsUsuario.pass)
            {
                dataGridView2.Rows.Add(iteracion.ToString());
            }
        }
    }
}
