using Denis01.Dominio;
using Denis01.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denis01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login entrar = new Login();
            ClsLogin logica = new ClsLogin();

            entrar.User = txtUser.Text;
            entrar.Pass = txtPass.Text;

            Boolean R = logica.logeo(entrar);

            if (R == true)
            {
                MessageBox.Show("Acceso Consedido");
            }
            else
            {
                MessageBox.Show("Acceso Restringido ");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
