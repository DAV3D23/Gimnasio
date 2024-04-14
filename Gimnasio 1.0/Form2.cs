using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gimnasio_1._0
{
    public partial class frmIniSesion : Form
    {
        public frmIniSesion()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string ingresar = "select * from Administradores where Nombre = '" + txtNombreUsuario.Text + "' and Contraseña = '" + txtContraUsuario.Text + "'";
            SqlCommand cmd = new SqlCommand(ingresar, Conexion.Conectar());
            SqlDataReader lector = cmd.ExecuteReader();

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContraUsuario.Text))
            {
                MessageBox.Show("INTRODUCE TUS DATOS", "DATOS REQUERIDOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lector.HasRows == true)
                {
                    frmPrincipal principal = new frmPrincipal();
                    MessageBox.Show("BIENVENIDO " + txtNombreUsuario.Text, "ACCESO CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("CONTRASEÑA O NOMBRE DE USUARIO INCORRECTO", "ACCESO INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
