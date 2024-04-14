namespace Gimnasio_1._0
{
    partial class frmIniSesion
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            txtNombreUsuario = new TextBox();
            txtContraUsuario = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Green;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(324, 268);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(149, 42);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "ACCEDER";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Teal;
            iconButton2.FlatStyle = FlatStyle.Popup;
            iconButton2.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(505, 268);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(149, 42);
            iconButton2.TabIndex = 4;
            iconButton2.Text = "SALIR";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(435, 85);
            label1.Name = "label1";
            label1.Size = new Size(109, 24);
            label1.TabIndex = 2;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(408, 171);
            label2.Name = "label2";
            label2.Size = new Size(158, 24);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtNombreUsuario.Location = new Point(359, 112);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "NOMBRE DE USUARIO";
            txtNombreUsuario.Size = new Size(258, 26);
            txtNombreUsuario.TabIndex = 1;
            // 
            // txtContraUsuario
            // 
            txtContraUsuario.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold);
            txtContraUsuario.Location = new Point(359, 198);
            txtContraUsuario.Name = "txtContraUsuario";
            txtContraUsuario.PasswordChar = '*';
            txtContraUsuario.PlaceholderText = "CONTRASEÑA DE USUARIO";
            txtContraUsuario.Size = new Size(258, 26);
            txtContraUsuario.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            iconPictureBox1.ForeColor = Color.OrangeRed;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox1.IconColor = Color.OrangeRed;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 315;
            iconPictureBox1.Location = new Point(3, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(315, 361);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox1.TabIndex = 6;
            iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(399, 9);
            label3.Name = "label3";
            label3.Size = new Size(201, 28);
            label3.TabIndex = 7;
            label3.Text = "INICIAR SESION";
            // 
            // frmIniSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(698, 366);
            Controls.Add(label3);
            Controls.Add(iconPictureBox1);
            Controls.Add(txtContraUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIniSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INICIO DE SESION";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label1;
        private Label label2;
        private TextBox txtNombreUsuario;
        private TextBox txtContraUsuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label3;
    }
}