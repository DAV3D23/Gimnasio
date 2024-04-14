using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Gimnasio_1._0
{
    public partial class frmEditarRegistro : Form
    {
        public frmEditarRegistro()
        {
            InitializeComponent();
        }

        private void frmEditarRegistro_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            dgvEditar.DataSource = verInfo();
            dgvEditar.Columns[0].Visible = false;

            dgvEditar.ClearSelection();


        }

        public DataTable verInfo() //clase para ver la informacion en el datagrid clientes
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consultaVer = "select ClienteID, Nombre, ApellidoPaterno, ApellidoMaterno, MembresiaTipo, FechaInicio, FechaFin from Clientes"; //consulta
            SqlCommand cmd2 = new SqlCommand(consultaVer, Conexion.Conectar()); //comando con la consuta y la conexion

            SqlDataAdapter da = new SqlDataAdapter(cmd2);

            da.Fill(dt);
            return dt;
        }

        private void btnBuscarRegistro_Click(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox para la búsqueda y convertirlo a minúsculas
            string searchText = txtBusqueda.Text.Trim().ToLower();

            // Verificar si el TextBox está vacío
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Por favor ingrese un término de búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el índice de la columna en la que deseas buscar (reemplaza 0 por el índice de tu columna)
            int columnIndex = 1; // Cambia 0 por el índice de tu columna

            // Realizar la búsqueda en la columna especificada del DataGridView usando LINQ
            var rows = dgvEditar.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString().ToLower().Contains(searchText));

            // Desactivar la selección de todas las filas
            dgvEditar.ClearSelection();

            // Verificar si se encontraron resultados
            if (rows.Any())
            {
                // Seleccionar la primera fila encontrada
                var firstRow = rows.First();
                firstRow.Selected = true;
                // Hacer que el DataGridView muestre la fila seleccionada
                dgvEditar.FirstDisplayedScrollingRowIndex = firstRow.Index;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para la búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvEditar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtClienteID.Text = dgvEditar.CurrentRow.Cells[0].Value.ToString();
                txtNombres.Text = dgvEditar.CurrentRow.Cells[1].Value.ToString();
                txtApellidoPaterno.Text = dgvEditar.CurrentRow.Cells[2].Value.ToString();
                txtApellidoMaterno.Text = dgvEditar.CurrentRow.Cells[3].Value.ToString();
                if (rbGimnasio.Text == dgvEditar.CurrentRow.Cells[4].Value.ToString())
                {
                    rbGimnasio.Checked = true;
                }
                else
                {
                    if (rbKickboxing.Text == dgvEditar.CurrentRow.Cells[4].Value.ToString())
                    {
                        rbKickboxing.Checked = true;
                    }
                    else
                    {
                        rbAmbos.Checked = true;
                    }
                }

                txtFechaInicio.Text = dgvEditar.CurrentRow.Cells[5].Value.ToString();
                txtFechaFin.Text = dgvEditar.CurrentRow.Cells[6].Value.ToString();
            }
            catch { }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //ACTUALIZA LOS DATOS
            string Tipo;
            Conexion.Conectar();
            string actualizar = "UPDATE clientes set Nombre = @Nombre, ApellidoPaterno = @ApellidoPaterno, " +
                "ApellidoMaterno = @ApellidoMaterno, MembresiaTipo = @MembresiaTipo, FechaInicio = @FechaInicio, FechaFin = @FechaFin " +
                "WHERE ClienteID = @ClienteID";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());

            if (string.IsNullOrWhiteSpace(txtNombres.Text) || //VALIDA DATOS VACIOS
                string.IsNullOrWhiteSpace(txtApellidoPaterno.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoMaterno.Text) ||
                string.IsNullOrWhiteSpace(txtFechaInicio.Text) ||
                string.IsNullOrWhiteSpace(txtFechaFin.Text))
            {
                MessageBox.Show("Selecciona un registro primero", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd2.Parameters.AddWithValue("@ClienteID", txtClienteID.Text);
                cmd2.Parameters.AddWithValue("@Nombre", txtNombres.Text);
                cmd2.Parameters.AddWithValue("@ApellidoPaterno", txtApellidoPaterno.Text);
                cmd2.Parameters.AddWithValue("@ApellidoMaterno", txtApellidoMaterno.Text);
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
                cmd2.Parameters.AddWithValue("@membresiaTipo", Tipo);
                cmd2.Parameters.AddWithValue("@FechaInicio", txtFechaInicio.Text);
                cmd2.Parameters.AddWithValue("@FechaFin", txtFechaFin.Text);

                cmd2.ExecuteNonQuery();

                MessageBox.Show("Los datos fueron actualizados con exito", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvEditar.DataSource = verInfo();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.verInfo();
            principal.verInfoVencida();
            principal.Show();
            this.Hide();

        }

        private void frmEditarRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
            
        }
    }
}
