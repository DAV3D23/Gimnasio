using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Gimnasio_1._0
{
    public partial class frmNuevoRegistro : Form
    {
        public frmNuevoRegistro()
        {
            InitializeComponent();
            txtFechaInicio.TextChanged += txtFechaInicio_TextChanged;
            txtFechaFin.TextChanged += txtFechaFin_TextChanged;

            txtFechaInicio.KeyPress += txtFechaInicio_KeyPress;
            txtFechaFin.KeyPress += txtFechaFin_KeyPress;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.verInfo();
            frmPrincipal.verInfoVencida();
            frmPrincipal.Show();
            this.Hide();

        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Tipo;
            Conexion.Conectar();
            string insertar = "INSERT INTO Clientes (nombre, apellidoPaterno, apellidoMaterno, membresiaTipo, fechaInicio, fechaFin) VALUES (@nombre,@apellidoPaterno,@apellidoMaterno,@membresiaTipo,@fechaInicio,@fechaFin)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion.Conectar());

            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoPaterno.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoMaterno.Text) ||
                string.IsNullOrWhiteSpace(txtFechaInicio.Text) ||
                string.IsNullOrWhiteSpace(txtFechaFin.Text))
            {
                MessageBox.Show("Introduce todos los datos primero", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                cmd.Parameters.AddWithValue("@nombre", txtNombres.Text);
                cmd.Parameters.AddWithValue("@apellidoPaterno", txtApellidoPaterno.Text);
                cmd.Parameters.AddWithValue("@apellidoMaterno", txtApellidoMaterno.Text);
                if (rbGimnasio.Checked)
                {
                    Tipo = "GIMNASIO";
                }
                else
                {
                    if (rbKickboxing.Checked)
                    {
                        Tipo = "KICKBOXING";
                    }
                    else
                    {
                        Tipo = "AMBOS";
                    }
                }
                cmd.Parameters.AddWithValue("@membresiaTipo", Tipo);
                cmd.Parameters.AddWithValue("@fechaInicio", txtFechaInicio.Text);

                cmd.Parameters.AddWithValue("@fechaFin", txtFechaFin.Text);




                cmd.ExecuteNonQuery();
                MessageBox.Show("Los datos se agregaron con exito", "REGISTRO CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombres.Clear();
                txtApellidoPaterno.Clear();
                txtApellidoMaterno.Clear();
                rbGimnasio.Checked = true;
                rbKickboxing.Checked = false;
                rbAmbos.Checked = false;
                txtFechaInicio.Clear();
                txtFechaFin.Clear();
            }
        }





        private void txtFechaInicio_TextChanged(object sender, EventArgs e)
        {
            if (txtFechaInicio.TextLength == 3 || txtFechaInicio.TextLength == 6)
            {
                // Agregar un guion después de los primeros 2 caracteres y después de los siguientes 5 caracteres
                if (txtFechaInicio.Text[txtFechaInicio.TextLength - 1] != '-')
                {
                    txtFechaInicio.Text = txtFechaInicio.Text.Insert(txtFechaInicio.TextLength - 1, "-");
                }
                // Colocar el cursor al final del texto
                txtFechaInicio.SelectionStart = txtFechaInicio.TextLength;
            }
        }

        private void txtFechaFin_TextChanged(object sender, EventArgs e)
        {
            if (txtFechaFin.TextLength == 3 || txtFechaFin.TextLength == 6)
            {
                // Agregar un guion después de los primeros 2 caracteres y después de los siguientes 5 caracteres
                if (txtFechaFin.Text[txtFechaFin.TextLength - 1] != '-')
                {
                    txtFechaFin.Text = txtFechaFin.Text.Insert(txtFechaFin.TextLength - 1, "-");
                }
                // Colocar el cursor al final del texto
                txtFechaFin.SelectionStart = txtFechaFin.TextLength;
            }
        }

        private void txtFechaInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                int selectionStart = txtFechaInicio.SelectionStart;
                if (selectionStart > 0 && txtFechaInicio.Text[selectionStart - 1] == '-')
                {
                    // Si se presiona la tecla de retroceso y el carácter anterior es un guion, eliminamos el guion
                    txtFechaInicio.Text = txtFechaInicio.Text.Remove(selectionStart - 1, 1);
                    txtFechaInicio.SelectionStart = selectionStart - 1;
                    e.Handled = true;
                }
            }
        }

        private void txtFechaFin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                int selectionStart = txtFechaFin.SelectionStart;
                if (selectionStart > 0 && txtFechaFin.Text[selectionStart - 1] == '-')
                {
                    // Si se presiona la tecla de retroceso y el carácter anterior es un guion, eliminamos el guion
                    txtFechaFin.Text = txtFechaFin.Text.Remove(selectionStart - 1, 1);
                    txtFechaFin.SelectionStart = selectionStart - 1;
                    e.Handled = true;
                }
            }
        }

        private void txtFechaInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (por ejemplo, retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtFechaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (por ejemplo, retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmNuevoRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
