namespace Gimnasio_1._0
{
    partial class frmEditarRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFechaFin = new TextBox();
            txtFechaInicio = new TextBox();
            groupBox1 = new GroupBox();
            rbGimnasio = new RadioButton();
            rbKickboxing = new RadioButton();
            rbAmbos = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtNombres = new TextBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            dgvEditar = new DataGridView();
            label5 = new Label();
            txtBusqueda = new TextBox();
            btnBuscarRegistro = new FontAwesome.Sharp.IconButton();
            txtClienteID = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditar).BeginInit();
            SuspendLayout();
            // 
            // txtFechaFin
            // 
            txtFechaFin.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtFechaFin.Location = new Point(31, 462);
            txtFechaFin.MaxLength = 10;
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.PlaceholderText = "DD-MM-YYYY";
            txtFechaFin.Size = new Size(318, 26);
            txtFechaFin.TabIndex = 30;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtFechaInicio.Location = new Point(31, 380);
            txtFechaInicio.MaxLength = 10;
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.PlaceholderText = "DD-MM-YYYY";
            txtFechaInicio.Size = new Size(318, 26);
            txtFechaInicio.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbGimnasio);
            groupBox1.Controls.Add(rbKickboxing);
            groupBox1.Controls.Add(rbAmbos);
            groupBox1.Location = new Point(31, 263);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 65);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // rbGimnasio
            // 
            rbGimnasio.AutoSize = true;
            rbGimnasio.ForeColor = Color.White;
            rbGimnasio.Location = new Point(6, 26);
            rbGimnasio.Name = "rbGimnasio";
            rbGimnasio.Size = new Size(101, 24);
            rbGimnasio.TabIndex = 9;
            rbGimnasio.TabStop = true;
            rbGimnasio.Text = "GIMNASIO";
            rbGimnasio.UseVisualStyleBackColor = true;
            // 
            // rbKickboxing
            // 
            rbKickboxing.AutoSize = true;
            rbKickboxing.ForeColor = Color.White;
            rbKickboxing.Location = new Point(113, 26);
            rbKickboxing.Name = "rbKickboxing";
            rbKickboxing.Size = new Size(115, 24);
            rbKickboxing.TabIndex = 10;
            rbKickboxing.TabStop = true;
            rbKickboxing.Text = "KICKBOXING";
            rbKickboxing.UseVisualStyleBackColor = true;
            // 
            // rbAmbos
            // 
            rbAmbos.AutoSize = true;
            rbAmbos.ForeColor = Color.White;
            rbAmbos.Location = new Point(234, 26);
            rbAmbos.Name = "rbAmbos";
            rbAmbos.Size = new Size(81, 24);
            rbAmbos.TabIndex = 11;
            rbAmbos.TabStop = true;
            rbAmbos.Text = "AMBOS";
            rbAmbos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(77, 236);
            label4.Name = "label4";
            label4.Size = new Size(230, 24);
            label4.TabIndex = 27;
            label4.Text = "TIPO DE MEMBRESIA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 424);
            label3.Name = "label3";
            label3.Size = new Size(279, 24);
            label3.TabIndex = 26;
            label3.Text = "FECHA DE TERMINACION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 343);
            label2.Name = "label2";
            label2.Size = new Size(261, 24);
            label2.TabIndex = 25;
            label2.Text = "FECHA DE INSCRIPCION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 26);
            label1.Name = "label1";
            label1.Size = new Size(257, 24);
            label1.TabIndex = 24;
            label1.Text = "EDITE EL FORMULARIO";
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtApellidoMaterno.Location = new Point(31, 189);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.PlaceholderText = "APELLIDO MATERNO";
            txtApellidoMaterno.Size = new Size(318, 26);
            txtApellidoMaterno.TabIndex = 23;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtApellidoPaterno.Location = new Point(31, 135);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.PlaceholderText = "APELLIDO PATERNO";
            txtApellidoPaterno.Size = new Size(318, 26);
            txtApellidoPaterno.TabIndex = 22;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtNombres.Location = new Point(31, 80);
            txtNombres.Name = "txtNombres";
            txtNombres.PlaceholderText = "NOMBRES";
            txtNombres.Size = new Size(318, 26);
            txtNombres.TabIndex = 21;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Teal;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 45;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(195, 495);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 52);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "SALIR";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Green;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 45;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(31, 495);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(154, 52);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "MODIFICAR";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // dgvEditar
            // 
            dgvEditar.AllowUserToAddRows = false;
            dgvEditar.AllowUserToDeleteRows = false;
            dgvEditar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditar.ImeMode = ImeMode.Disable;
            dgvEditar.Location = new Point(367, 135);
            dgvEditar.Name = "dgvEditar";
            dgvEditar.ReadOnly = true;
            dgvEditar.RowHeadersWidth = 51;
            dgvEditar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEditar.Size = new Size(657, 392);
            dgvEditar.TabIndex = 31;
            dgvEditar.CellContentClick += dgvEditar_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(442, 108);
            label5.Name = "label5";
            label5.Size = new Size(500, 24);
            label5.TabIndex = 32;
            label5.Text = "PRIMERO SELECCIONE EL REGISTRO A EDITAR";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtBusqueda.Location = new Point(442, 59);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "INTRODUCE PRIMER APELLIDO";
            txtBusqueda.Size = new Size(263, 26);
            txtBusqueda.TabIndex = 34;
            // 
            // btnBuscarRegistro
            // 
            btnBuscarRegistro.BackColor = Color.FromArgb(0, 192, 192);
            btnBuscarRegistro.FlatStyle = FlatStyle.Popup;
            btnBuscarRegistro.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            btnBuscarRegistro.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarRegistro.IconColor = Color.Black;
            btnBuscarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarRegistro.IconSize = 40;
            btnBuscarRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarRegistro.Location = new Point(731, 48);
            btnBuscarRegistro.Name = "btnBuscarRegistro";
            btnBuscarRegistro.Size = new Size(211, 44);
            btnBuscarRegistro.TabIndex = 33;
            btnBuscarRegistro.Text = "Buscar Registro";
            btnBuscarRegistro.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarRegistro.UseVisualStyleBackColor = false;
            btnBuscarRegistro.Click += btnBuscarRegistro_Click;
            // 
            // txtClienteID
            // 
            txtClienteID.Enabled = false;
            txtClienteID.Location = new Point(382, 102);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(54, 27);
            txtClienteID.TabIndex = 35;
            txtClienteID.Visible = false;
            // 
            // frmEditarRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1085, 587);
            Controls.Add(txtClienteID);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscarRegistro);
            Controls.Add(label5);
            Controls.Add(dgvEditar);
            Controls.Add(txtFechaFin);
            Controls.Add(txtFechaInicio);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtApellidoMaterno);
            Controls.Add(txtApellidoPaterno);
            Controls.Add(txtNombres);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditarRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EDITAR REGISTRO";
            FormClosing += frmEditarRegistro_FormClosing;
            Load += frmEditarRegistro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFechaFin;
        private TextBox txtFechaInicio;
        private GroupBox groupBox1;
        private RadioButton rbGimnasio;
        private RadioButton rbKickboxing;
        private RadioButton rbAmbos;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private TextBox txtNombres;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private DataGridView dgvEditar;
        private Label label5;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscarRegistro;
        private TextBox txtClienteID;
    }
}