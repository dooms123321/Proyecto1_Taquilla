namespace Proyecto_Taquilla.Vistas
{
    partial class vistaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistaLogin));
            btnAceptar = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSalir = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(144, 316);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 37);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(144, 137);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(245, 34);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(144, 222);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(245, 34);
            txtContraseña.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(144, 92);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(193, 29);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Ingresar usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(144, 190);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(234, 29);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Ingresar Contraseña\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(78, 207);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(277, 316);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 37);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(144, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(245, 35);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Ingreso al Sistema";
            // 
            // vistaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 378);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnAceptar);
            Name = "vistaLogin";
            Text = "vistaLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label lblUsuario;
        private Label lblContraseña;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSalir;
        private Label lblTitulo;
    }
}