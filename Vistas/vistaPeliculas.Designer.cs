namespace Proyecto_Taquilla.Vistas
{
    partial class vistaPeliculas
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
            dgvPeliculas = new DataGridView();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtIdPelicula = new TextBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(457, 22);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.ReadOnly = true;
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.Size = new Size(653, 446);
            dgvPeliculas.TabIndex = 0;
            dgvPeliculas.SelectionChanged += dgvPeliculas_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(70, 186);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(70, 233);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(26, 439);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(151, 439);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(283, 439);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // txtIdPelicula
            // 
            txtIdPelicula.Location = new Point(70, 135);
            txtIdPelicula.Name = "txtIdPelicula";
            txtIdPelicula.Size = new Size(125, 27);
            txtIdPelicula.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(151, 478);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // vistaPeliculas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 519);
            Controls.Add(btnLimpiar);
            Controls.Add(txtIdPelicula);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(dgvPeliculas);
            Name = "vistaPeliculas";
            Text = "vistaPeliculas";
            Load += vistaPeliculas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPeliculas;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox txtIdPelicula;
        private Button btnLimpiar;
    }
}