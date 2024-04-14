namespace Gimnasio_1._0
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnNuevoRegistro = new FontAwesome.Sharp.IconButton();
            btnBuscarRegistro = new FontAwesome.Sharp.IconButton();
            btnEliminarRegistro = new FontAwesome.Sharp.IconButton();
            dgvInfoVencida = new DataGridView();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            btnEditarRegistro = new FontAwesome.Sharp.IconButton();
            timerHora = new System.Windows.Forms.Timer(components);
            txtBusqueda = new TextBox();
            dgvListadoClientes = new DataGridView();
            txtClienteID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvInfoVencida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 32);
            label1.Name = "label1";
            label1.Size = new Size(412, 24);
            label1.TabIndex = 1;
            label1.Text = "lISTADO DE PERSONAS REGISTRADAS";
            // 
            // btnNuevoRegistro
            // 
            btnNuevoRegistro.BackColor = Color.Green;
            btnNuevoRegistro.FlatStyle = FlatStyle.Popup;
            btnNuevoRegistro.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            btnNuevoRegistro.ForeColor = Color.White;
            btnNuevoRegistro.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnNuevoRegistro.IconColor = Color.Black;
            btnNuevoRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoRegistro.Location = new Point(830, 195);
            btnNuevoRegistro.Name = "btnNuevoRegistro";
            btnNuevoRegistro.Size = new Size(225, 47);
            btnNuevoRegistro.TabIndex = 3;
            btnNuevoRegistro.Text = "Nuevo Registro";
            btnNuevoRegistro.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoRegistro.UseVisualStyleBackColor = false;
            btnNuevoRegistro.Click += btnNuevoRegistro_Click;
            // 
            // btnBuscarRegistro
            // 
            btnBuscarRegistro.BackColor = Color.FromArgb(0, 192, 192);
            btnBuscarRegistro.FlatStyle = FlatStyle.Popup;
            btnBuscarRegistro.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            btnBuscarRegistro.ForeColor = Color.White;
            btnBuscarRegistro.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarRegistro.IconColor = Color.Black;
            btnBuscarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarRegistro.IconSize = 40;
            btnBuscarRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarRegistro.Location = new Point(830, 110);
            btnBuscarRegistro.Name = "btnBuscarRegistro";
            btnBuscarRegistro.Size = new Size(225, 41);
            btnBuscarRegistro.TabIndex = 4;
            btnBuscarRegistro.Text = "Buscar Registro";
            btnBuscarRegistro.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarRegistro.UseVisualStyleBackColor = false;
            btnBuscarRegistro.Click += btnBuscarRegistro_Click;
            // 
            // btnEliminarRegistro
            // 
            btnEliminarRegistro.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarRegistro.FlatStyle = FlatStyle.Popup;
            btnEliminarRegistro.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            btnEliminarRegistro.ForeColor = Color.White;
            btnEliminarRegistro.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
            btnEliminarRegistro.IconColor = Color.Black;
            btnEliminarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarRegistro.IconSize = 40;
            btnEliminarRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarRegistro.Location = new Point(830, 395);
            btnEliminarRegistro.Name = "btnEliminarRegistro";
            btnEliminarRegistro.Size = new Size(225, 47);
            btnEliminarRegistro.TabIndex = 5;
            btnEliminarRegistro.Text = "Eliminar Registro";
            btnEliminarRegistro.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarRegistro.UseVisualStyleBackColor = false;
            btnEliminarRegistro.Click += btnEliminarRegistro_Click;
            // 
            // dgvInfoVencida
            // 
            dgvInfoVencida.AllowUserToAddRows = false;
            dgvInfoVencida.AllowUserToDeleteRows = false;
            dgvInfoVencida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInfoVencida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfoVencida.Location = new Point(10, 360);
            dgvInfoVencida.MultiSelect = false;
            dgvInfoVencida.Name = "dgvInfoVencida";
            dgvInfoVencida.ReadOnly = true;
            dgvInfoVencida.RowHeadersWidth = 51;
            dgvInfoVencida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInfoVencida.Size = new Size(766, 227);
            dgvInfoVencida.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(336, 333);
            label2.Name = "label2";
            label2.Size = new Size(266, 24);
            label2.TabIndex = 7;
            label2.Text = "MEMBRECIAS VENCIDAS";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(782, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(291, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(207, 333);
            label4.Name = "label4";
            label4.Size = new Size(123, 24);
            label4.TabIndex = 10;
            label4.Text = "ATENCION";
            // 
            // btnEditarRegistro
            // 
            btnEditarRegistro.BackColor = Color.FromArgb(192, 192, 0);
            btnEditarRegistro.FlatStyle = FlatStyle.Popup;
            btnEditarRegistro.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            btnEditarRegistro.ForeColor = Color.White;
            btnEditarRegistro.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            btnEditarRegistro.IconColor = Color.Black;
            btnEditarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarRegistro.Location = new Point(830, 292);
            btnEditarRegistro.Name = "btnEditarRegistro";
            btnEditarRegistro.Size = new Size(225, 47);
            btnEditarRegistro.TabIndex = 11;
            btnEditarRegistro.Text = "Editar Registro";
            btnEditarRegistro.TextAlign = ContentAlignment.MiddleRight;
            btnEditarRegistro.UseVisualStyleBackColor = false;
            btnEditarRegistro.Click += btnEditarRegistro_Click;
            // 
            // timerHora
            // 
            timerHora.Tick += timerHora_Tick_1;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusqueda.ForeColor = Color.Red;
            txtBusqueda.Location = new Point(815, 78);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "INTRODUCE PRIMER APELLIDO";
            txtBusqueda.Size = new Size(258, 26);
            txtBusqueda.TabIndex = 12;
            // 
            // dgvListadoClientes
            // 
            dgvListadoClientes.AllowUserToAddRows = false;
            dgvListadoClientes.AllowUserToDeleteRows = false;
            dgvListadoClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListadoClientes.Location = new Point(12, 59);
            dgvListadoClientes.MultiSelect = false;
            dgvListadoClientes.Name = "dgvListadoClientes";
            dgvListadoClientes.ReadOnly = true;
            dgvListadoClientes.RowHeadersWidth = 51;
            dgvListadoClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoClientes.Size = new Size(764, 255);
            dgvListadoClientes.TabIndex = 13;
            dgvListadoClientes.CellContentClick += dgvListadoClientes_CellContentClick;
            // 
            // txtClienteID
            // 
            txtClienteID.Enabled = false;
            txtClienteID.Location = new Point(680, 26);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(60, 27);
            txtClienteID.TabIndex = 14;
            txtClienteID.Visible = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1085, 604);
            Controls.Add(txtClienteID);
            Controls.Add(dgvListadoClientes);
            Controls.Add(txtBusqueda);
            Controls.Add(btnEditarRegistro);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(dgvInfoVencida);
            Controls.Add(btnEliminarRegistro);
            Controls.Add(btnBuscarRegistro);
            Controls.Add(btnNuevoRegistro);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PANTALLA PRINCIPAL";
            FormClosing += frmPrincipal_FormClosing;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInfoVencida).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvListadoClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private FontAwesome.Sharp.IconButton btnNuevoRegistro;
        private FontAwesome.Sharp.IconButton btnBuscarRegistro;
        private FontAwesome.Sharp.IconButton btnEliminarRegistro;
        private DataGridView dgvInfoVencida;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnEditarRegistro;
        private System.Windows.Forms.Timer timerHora;
        private TextBox txtBusqueda;
        public DataGridView dgvListadoClientes;
        private TextBox txtClienteID;
    }
}
