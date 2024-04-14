using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gimnasio_1._0
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();


        }


        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            //Al dar click abrimos el formulario en cuestion
            frmNuevoRegistro frmNuevoRegistro = new frmNuevoRegistro();
            frmNuevoRegistro.ShowDialog();
            this.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            //Para que llame a la clase conexion y su metodo conectar y abra la conexion a la base de datos
            Conexion.Conectar();
            //MessageBox.Show("Exito");

            dgvListadoClientes.DataSource = verInfo();
            dgvInfoVencida.DataSource = verInfoVencida();

            timerHora.Enabled = true;

            dgvListadoClientes.Columns[0].Visible = false;
            dgvInfoVencida.ClearSelection();
            dgvListadoClientes.ClearSelection();



        }

        public DataTable verInfo() //clase para ver la informacion en el datagrid clientes
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consultaVer = "select ClienteID, Nombre, ApellidoPaterno, ApellidoMaterno, MembresiaTipo, FechaInicio, FechaFin from Clientes"; //consulta
            SqlCommand cmd = new SqlCommand(consultaVer, Conexion.Conectar()); //comando con la consuta y la conexion

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        public DataTable verInfoVencida() //clase para ver la informacion en el datagrid membrecia vencida
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consultaVencida = "select Nombre, ApellidoPaterno, MembresiaTipo, FechaInicio, FechaFin from Clientes where fechaFin<GETDATE();"; //consulta
            SqlCommand cmd = new SqlCommand(consultaVencida, Conexion.Conectar()); //comando con la consuta y la conexion

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void timerHora_Tick_1(object sender, EventArgs e)
        {
            // lblHora.Text = DateTime.Now.ToString("hh:mm:ss"); //obtiene la hora actual
        }

        private void btnBuscarRegistro_Click(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox para la búsqueda y convertirlo a minúsculas
            string searchText = txtBusqueda.Text.Trim().ToLower();

            // Verificar si el TextBox está vacío
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Por favor ingrese un término de búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Obtener el índice de la columna en la que deseas buscar (reemplaza 0 por el índice de tu columna)
            int columnIndex = 2; // Cambia 0 por el índice de tu columna

            // Realizar la búsqueda en la columna especificada del DataGridView usando LINQ
            var rows = dgvListadoClientes.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString().ToLower().Contains(searchText));

            // Desactivar la selección de todas las filas
            dgvListadoClientes.ClearSelection();

            // Verificar si se encontraron resultados
            if (rows.Any())
            {
                // Seleccionar la primera fila encontrada
                var firstRow = rows.First();
                firstRow.Selected = true;
                // Hacer que el DataGridView muestre la fila seleccionada
                dgvListadoClientes.FirstDisplayedScrollingRowIndex = firstRow.Index;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para la búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvListadoClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtClienteID.Text = dgvListadoClientes.CurrentRow.Cells[0].Value.ToString();
            }
            catch { }

        }

        private void btnEditarRegistro_Click(object sender, EventArgs e)
        {
            frmEditarRegistro editarRegistro = new frmEditarRegistro();
            editarRegistro.ShowDialog();
            this.Hide();


        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {

            Conexion.Conectar();
            string eliminar = "DELETE FROM Clientes WHERE ClienteID = @ClienteID";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());

            // Verificar si hay una fila seleccionada en el DataGridView
            if (dgvListadoClientes.SelectedRows.Count > 0)
            {
                cmd3.Parameters.AddWithValue("@ClienteID", txtClienteID.Text);

                cmd3.ExecuteNonQuery();

                MessageBox.Show("Registro eliminado con exito", "Registro Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvListadoClientes.DataSource = verInfo();
                dgvInfoVencida.DataSource = verInfoVencida();
            }
            else
            {
                // Mostrar mensaje de advertencia si no hay ninguna fila seleccionada
                MessageBox.Show("Por favor, selecciona un registro antes de intentar eliminarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro que quieres salir?", "Confirmacion", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                Environment.Exit(0);
            }
            else
            {
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
            }
            
        }
    }
}
