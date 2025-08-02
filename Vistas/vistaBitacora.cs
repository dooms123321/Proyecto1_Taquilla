using Proyecto_Taquilla.Controlador;
using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taquilla.Vistas
{
    public partial class vistaBitacora : Form
    {
        private BitacoraControlador controlador;
        public vistaBitacora()
        {
            InitializeComponent();
            controlador = new BitacoraControlador();

            //cargar las columnas
            dgvBitacora.Columns.Add("IdBitacora", "ID");
            dgvBitacora.Columns.Add("FechaBitacora", "Fecha");
            dgvBitacora.Columns.Add("AccionBitacora", "Acción");
            dgvBitacora.Columns.Add("IdUsuario", "ID Usuario");
            dgvBitacora.Columns.Add("IdAplicacion", "ID Aplicación");
            dgvBitacora.Columns.Add("IpBitacora", "IP");
            dgvBitacora.Columns.Add("NombrePcBitacora", "Nombre PC");
            CargarTodasLasBitacoras();
        }
        private void CargarTodasLasBitacoras()
        {
            dgvBitacora.Rows.Clear();

            List<Bitacora> bitacoras = controlador.ObtenerBitacorasPorFechas("2025-01-01", "2030-12-31");

            foreach (var bitacora in bitacoras)
            {
                dgvBitacora.Rows.Add(bitacora.IdBitacora, bitacora.FechaBitacora, bitacora.AccionBitacora, bitacora.IdUsuario, bitacora.IdAplicacion, bitacora.IpBitacora, bitacora.NombrePcBitacora);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fechaInicio = txtPrimeraFecha.Text.Trim();
            string fechaFin = txtSegundaFecha.Text.Trim();

            //formato de fecha Año-Mes-Dia
            if (!DateTime.TryParseExact(fechaInicio, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _) ||
                !DateTime.TryParseExact(fechaFin, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Por favor ingresa fechas válidas con el formato: yyyy-MM-dd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvBitacora.Rows.Clear();
            List<Bitacora> lista = controlador.ObtenerBitacorasPorFechas(fechaInicio, fechaFin);

            foreach (var bitacora in lista)
            {
                dgvBitacora.Rows.Add(bitacora.IdBitacora, bitacora.FechaBitacora, bitacora.AccionBitacora, bitacora.IdUsuario, bitacora.IdAplicacion, bitacora.IpBitacora, bitacora.NombrePcBitacora);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            CargarTodasLasBitacoras();
            txtPrimeraFecha.Clear();
            txtSegundaFecha.Clear();
        }

        private void dgvBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
