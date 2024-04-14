using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio_1._0
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO Administradores (Nombre, Contraseña) VALUES (@Nombre,@Contraseña)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion.Conectar());

            if (string.IsNullOrWhiteSpace(txtNombreAdmin.Text) ||
                string.IsNullOrWhiteSpace(txtContraAdmin.Text))
            {
                MessageBox.Show("Introduce todos los datos primero", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                cmd.Parameters.AddWithValue("@Nombre", txtNombreAdmin.Text);
                cmd.Parameters.AddWithValue("@Contraseña", txtContraAdmin.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos se agregaron con exito", "REGISTRO CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmIniSesion iniSesion = new frmIniSesion();
                iniSesion.Show();
                this.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
