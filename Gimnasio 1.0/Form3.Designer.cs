namespace Gimnasio_1._0
{
    partial class frmNuevoRegistro
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
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            txtNombres = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtApellidoMaterno = new TextBox();
            label1 = new Label();
            label2 = new Label();
            rbGimnasio = new RadioButton();
            rbKickboxing = new RadioButton();
            rbAmbos = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtFechaInicio = new TextBox();
            txtFechaFin = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Green;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(103, 504);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(157, 52);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Teal;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(266, 504);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(157, 52);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "SALIR";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += iconButton2_Click;
            // 
            // txtNombres
            // 
            txtNombres.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtNombres.Location = new Point(105, 78);
            txtNombres.Name = "txtNombres";
            txtNombres.PlaceholderText = "NOMBRES";
            txtNombres.Size = new Size(318, 26);
            txtNombres.TabIndex = 2;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtApellidoPaterno.Location = new Point(105, 133);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.PlaceholderText = "APELLIDO PATERNO";
            txtApellidoPaterno.Size = new Size(318, 26);
            txtApellidoPaterno.TabIndex = 3;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtApellidoMaterno.Location = new Point(105, 187);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.PlaceholderText = "APELLIDO MATERNO";
            txtApellidoMaterno.Size = new Size(318, 26);
            txtApellidoMaterno.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(133, 24);
            label1.Name = "label1";
            label1.Size = new Size(260, 24);
            label1.TabIndex = 7;
            label1.Text = "LLENE EL FORMULARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(133, 341);
            label2.Name = "label2";
            label2.Size = new Size(261, 24);
            label2.TabIndex = 8;
            label2.Text = "FECHA DE INSCRIPCION";
            // 
            // rbGimnasio
            // 
            rbGimnasio.AutoSize = true;
            rbGimnasio.Checked = true;
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
            rbAmbos.Text = "AMBOS";
            rbAmbos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(124, 422);
            label3.Name = "label3";
            label3.Size = new Size(279, 24);
            label3.TabIndex = 14;
            label3.Text = "FECHA DE TERMINACION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(151, 234);
            label4.Name = "label4";
            label4.Size = new Size(230, 24);
            label4.TabIndex = 15;
            label4.Text = "TIPO DE MEMBRESIA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbGimnasio);
            groupBox1.Controls.Add(rbKickboxing);
            groupBox1.Controls.Add(rbAmbos);
            groupBox1.Location = new Point(105, 261);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 65);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtFechaInicio.Location = new Point(105, 378);
            txtFechaInicio.MaxLength = 10;
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.PlaceholderText = "DD-MM-YYYY";
            txtFechaInicio.Size = new Size(318, 26);
            txtFechaInicio.TabIndex = 17;
            txtFechaInicio.TextChanged += txtFechaInicio_TextChanged;
            txtFechaInicio.KeyDown += txtFechaInicio_KeyDown;
            txtFechaInicio.KeyPress += txtFechaInicio_KeyPress;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtFechaFin.Location = new Point(105, 460);
            txtFechaFin.MaxLength = 10;
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.PlaceholderText = "DD-MM-YYYY";
            txtFechaFin.Size = new Size(318, 26);
            txtFechaFin.TabIndex = 18;
            txtFechaFin.TextChanged += txtFechaFin_TextChanged;
            txtFechaFin.KeyDown += txtFechaFin_KeyDown;
            txtFechaFin.KeyPress += txtFechaFin_KeyPress;
            // 
            // frmNuevoRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(507, 573);
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
            Controls.Add(btnRegistrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNuevoRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NUEVO REGISTRO";
            Load += frmNuevoRegistro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private TextBox txtNombres;
        private TextBox txtApellidoPaterno;
        private TextBox txtApellidoMaterno;
        private Label label1;
        private Label label2;
        private RadioButton rbGimnasio;
        private RadioButton rbKickboxing;
        private RadioButton rbAmbos;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtFechaInicio;
        private TextBox txtFechaFin;
    }
}