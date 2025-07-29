namespace Proyecto_Taquilla.Vistas
{
    partial class vistaUsuarios
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
            dgvUsuarios = new DataGridView();
            txtIdUsuario = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(471, 26);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(653, 446);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Font = new Font("Times New Roman", 10.8F);
            txtIdUsuario.Location = new Point(58, 179);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(156, 28);
            txtIdUsuario.TabIndex = 13;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Times New Roman", 12F);
            btnEliminar.Location = new Point(290, 443);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Times New Roman", 12F);
            btnEditar.Location = new Point(158, 443);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Times New Roman", 12F);
            btnAgregar.Location = new Point(33, 443);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Times New Roman", 10.8F);
            txtContraseña.Location = new Point(58, 333);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(234, 28);
            txtContraseña.TabIndex = 9;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Times New Roman", 10.8F);
            txtUsuario.Location = new Point(58, 255);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(234, 28);
            txtUsuario.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.Location = new Point(56, 142);
            label1.Name = "label1";
            label1.Size = new Size(110, 23);
            label1.TabIndex = 14;
            label1.Text = "Id_Usuarios";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(58, 227);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 15;
            label2.Text = "Usuarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(58, 305);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 16;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 26);
            label4.Name = "label4";
            label4.Size = new Size(240, 35);
            label4.TabIndex = 17;
            label4.Text = "CRUD - Usuarios";
            label4.Click += label4_Click;
            // 
            // vistaUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 518);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdUsuario);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(dgvUsuarios);
            Name = "vistaUsuarios";
            Text = "vistaUsuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private TextBox txtIdUsuario;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}