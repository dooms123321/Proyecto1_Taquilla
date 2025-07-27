using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaquillaPeliculas.Controlador;

namespace Proyecto_Taquilla.Vistas
{
    public partial class vistaUsuarios : Form
    {
        private UsuarioController controller = new UsuarioController();
        public vistaUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            List<Usuario> lista = controller.CargarUsuarios();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = lista;
        }

        private void LimpiarCampos()
        {
            txtIdUsuario.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdUsuario.Text, out int id))
            {
                MessageBox.Show("ID invalido.");
                return;
            }

            string nombre = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            controller.AgregarUsuario(id, nombre, contraseña);
            CargarUsuarios();
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdUsuario.Text, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            string nombre = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            controller.ActualizarUsuario(id, nombre, contraseña);
            CargarUsuarios();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdUsuario.Text, out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            var confirm = MessageBox.Show("¿Eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                controller.EliminarUsuario(id);
                CargarUsuarios();
                LimpiarCampos();
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                Usuario seleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                txtIdUsuario.Text = seleccionado.Id_usuario.ToString();
                txtUsuario.Text = seleccionado.UsuarioNombre;
                txtContraseña.Text = seleccionado.Contraseña;
            }
        }
    }
}
