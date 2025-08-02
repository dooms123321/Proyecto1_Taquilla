namespace Proyecto_Taquilla.Vistas
{
    partial class vistaBitacora
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
            dgvBitacora = new DataGridView();
            lblTitulo = new Label();
            lblSegundafecha = new Label();
            lblPrimeraFecha = new Label();
            txtPrimeraFecha = new TextBox();
            txtSegundaFecha = new TextBox();
            btnBuscar = new Button();
            btnReiniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
            SuspendLayout();
            // 
            // dgvBitacora
            // 
            dgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBitacora.Location = new Point(407, 43);
            dgvBitacora.Name = "dgvBitacora";
            dgvBitacora.ReadOnly = true;
            dgvBitacora.RowHeadersWidth = 51;
            dgvBitacora.Size = new Size(826, 446);
            dgvBitacora.TabIndex = 1;
            dgvBitacora.CellContentClick += dgvBitacora_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(45, 62);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(274, 35);
            lblTitulo.TabIndex = 23;
            lblTitulo.Text = "Bitacora del Sistema";
            lblTitulo.Click += label4_Click;
            // 
            // lblSegundafecha
            // 
            lblSegundafecha.AutoSize = true;
            lblSegundafecha.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblSegundafecha.Location = new Point(49, 257);
            lblSegundafecha.Name = "lblSegundafecha";
            lblSegundafecha.Size = new Size(136, 23);
            lblSegundafecha.TabIndex = 22;
            lblSegundafecha.Text = "Segunda Fecha";
            // 
            // lblPrimeraFecha
            // 
            lblPrimeraFecha.AutoSize = true;
            lblPrimeraFecha.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblPrimeraFecha.Location = new Point(49, 172);
            lblPrimeraFecha.Name = "lblPrimeraFecha";
            lblPrimeraFecha.Size = new Size(133, 23);
            lblPrimeraFecha.TabIndex = 21;
            lblPrimeraFecha.Text = "Primera Fecha";
            // 
            // txtPrimeraFecha
            // 
            txtPrimeraFecha.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrimeraFecha.Location = new Point(49, 207);
            txtPrimeraFecha.Name = "txtPrimeraFecha";
            txtPrimeraFecha.Size = new Size(202, 34);
            txtPrimeraFecha.TabIndex = 20;
            // 
            // txtSegundaFecha
            // 
            txtSegundaFecha.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSegundaFecha.Location = new Point(49, 292);
            txtSegundaFecha.Multiline = true;
            txtSegundaFecha.Name = "txtSegundaFecha";
            txtSegundaFecha.Size = new Size(202, 27);
            txtSegundaFecha.TabIndex = 19;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(72, 397);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReiniciar.Location = new Point(225, 397);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(94, 29);
            btnReiniciar.TabIndex = 25;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // vistaBitacora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 512);
            Controls.Add(btnReiniciar);
            Controls.Add(btnBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(lblSegundafecha);
            Controls.Add(lblPrimeraFecha);
            Controls.Add(txtPrimeraFecha);
            Controls.Add(txtSegundaFecha);
            Controls.Add(dgvBitacora);
            Name = "vistaBitacora";
            Text = "vistaBitacora";
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBitacora;
        private Label lblTitulo;
        private Label lblSegundafecha;
        private Label lblPrimeraFecha;
        private TextBox txtPrimeraFecha;
        private TextBox txtSegundaFecha;
        private Button btnBuscar;
        private Button btnReiniciar;
    }
}