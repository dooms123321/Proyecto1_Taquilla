namespace Proyecto_Taquilla.Vistas
{
    partial class vistaCine
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
            labelCine = new Label();
            txbIDCine = new TextBox();
            labelNombre = new Label();
            txbNombre = new TextBox();
            labelPlaza = new Label();
            txbID_plaza = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvCine = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCine).BeginInit();
            SuspendLayout();
            // 
            // labelCine
            // 
            labelCine.AutoSize = true;
            labelCine.Location = new Point(26, 85);
            labelCine.Name = "labelCine";
            labelCine.Size = new Size(71, 25);
            labelCine.TabIndex = 0;
            labelCine.Text = "ID_Cine";
            labelCine.Click += label1_Click;
            // 
            // txbIDCine
            // 
            txbIDCine.Location = new Point(26, 113);
            txbIDCine.Name = "txbIDCine";
            txbIDCine.Size = new Size(150, 31);
            txbIDCine.TabIndex = 1;
            txbIDCine.TextChanged += txbIDCine_TextChanged;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(26, 164);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(78, 25);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            labelNombre.Click += labelNombre_Click;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(26, 192);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(150, 31);
            txbNombre.TabIndex = 3;
            txbNombre.TextChanged += txbNombre_TextChanged;
            // 
            // labelPlaza
            // 
            labelPlaza.AutoSize = true;
            labelPlaza.Location = new Point(26, 238);
            labelPlaza.Name = "labelPlaza";
            labelPlaza.Size = new Size(78, 25);
            labelPlaza.TabIndex = 4;
            labelPlaza.Text = "ID_plaza";
            labelPlaza.Click += labelPlaza_Click;
            // 
            // txbID_plaza
            // 
            txbID_plaza.Location = new Point(26, 266);
            txbID_plaza.Name = "txbID_plaza";
            txbID_plaza.Size = new Size(150, 31);
            txbID_plaza.TabIndex = 5;
            txbID_plaza.TextChanged += txbID_plaza_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 375);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(130, 375);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(248, 375);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvCine
            // 
            dgvCine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCine.Location = new Point(202, 15);
            dgvCine.Name = "dgvCine";
            dgvCine.RowHeadersWidth = 62;
            dgvCine.Size = new Size(572, 322);
            dgvCine.TabIndex = 9;
            dgvCine.CellContentClick += dgvCine_CellContentClick;
            // 
            // vistaCine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCine);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txbID_plaza);
            Controls.Add(labelPlaza);
            Controls.Add(txbNombre);
            Controls.Add(labelNombre);
            Controls.Add(txbIDCine);
            Controls.Add(labelCine);
            Name = "vistaCine";
            Text = "vistaCine";
            Load += vistaCine_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCine;
        private TextBox txbIDCine;
        private Label labelNombre;
        private TextBox txbNombre;
        private Label labelPlaza;
        private TextBox txbID_plaza;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvCine;
    }
}