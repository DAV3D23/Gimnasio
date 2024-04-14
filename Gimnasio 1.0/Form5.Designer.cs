namespace Gimnasio_1._0
{
    partial class frmCrearUsuario
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
            label1 = new Label();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            txtNombreAdmin = new TextBox();
            txtContraAdmin = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(289, 18);
            label1.Name = "label1";
            label1.Size = new Size(436, 24);
            label1.TabIndex = 0;
            label1.Text = "CREE SU USUARIO DE ADMINISTRADOR";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Green;
            btnRegistrar.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(302, 240);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(188, 48);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Teal;
            btnCancelar.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(517, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(175, 48);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "SALIR";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombreAdmin
            // 
            txtNombreAdmin.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreAdmin.Location = new Point(363, 98);
            txtNombreAdmin.Name = "txtNombreAdmin";
            txtNombreAdmin.PlaceholderText = "NOMBRE DE USUARIO";
            txtNombreAdmin.Size = new Size(263, 26);
            txtNombreAdmin.TabIndex = 3;
            // 
            // txtContraAdmin
            // 
            txtContraAdmin.Font = new Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContraAdmin.Location = new Point(363, 176);
            txtContraAdmin.Name = "txtContraAdmin";
            txtContraAdmin.PlaceholderText = "CONTRASEÑA DE USUARIO";
            txtContraAdmin.Size = new Size(263, 26);
            txtContraAdmin.TabIndex = 4;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(64, 64, 64);
            iconPictureBox1.ForeColor = Color.OrangeRed;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            iconPictureBox1.IconColor = Color.OrangeRed;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 255;
            iconPictureBox1.Location = new Point(12, 33);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(266, 255);
            iconPictureBox1.TabIndex = 5;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(435, 71);
            label2.Name = "label2";
            label2.Size = new Size(109, 24);
            label2.TabIndex = 6;
            label2.Text = "USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(414, 149);
            label3.Name = "label3";
            label3.Size = new Size(158, 24);
            label3.TabIndex = 7;
            label3.Text = "CONTRASEÑA";
            // 
            // frmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(742, 315);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(iconPictureBox1);
            Controls.Add(txtContraAdmin);
            Controls.Add(txtNombreAdmin);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCrearUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private TextBox txtNombreAdmin;
        private TextBox txtContraAdmin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private Label label3;
    }
}