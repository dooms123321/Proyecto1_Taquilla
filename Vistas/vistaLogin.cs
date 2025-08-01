using Prototipo_Taquilla_Cliente;
using Proyecto_Taquilla.Controlador;
using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Hecho por Kenph Luna 01/08/2025

namespace Proyecto_Taquilla.Vistas
{
    public partial class vistaLogin : Form
    {
        public vistaLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //compara que no hay campos vacios y lanza un mensaje de error
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("No pueden haber campos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //trycatch para evitar que el programa explote si hay un error en la conexion
            try
            {
                //reutilizacion de codigo creando objeto UsuarioDAO y usuarioAConsultar
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                string usuarioNombre = txtUsuario.Text.Trim();  //aqui le enviamos el nombre del usuario al query para comparar despues
                Usuario usuarioAConsultar = usuarioDAO.Query(usuarioNombre);

                if (usuarioAConsultar != null && usuarioAConsultar.Contraseña == txtContraseña.Text)
                {
                    MessageBox.Show("Bienvenido al SISTEMA", "Mensaje de bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Falta modificar aquí - para que se guarde el usuario a bitacora

                    //UsuarioConectado.IdUsuario = usuario.Id_usuario;
                    //UsuarioConectado.NombreUsuario = usuario.UsuarioNombre;

                    //Bitacora bitacora = new Bitacora();
                    //bitacora.RegistrarEntrada(usuario.Id_usuario, 1000, "LGI");

                    vistaMDIGeneral ventanaMDIGeneral = new vistaMDIGeneral();
                    ventanaMDIGeneral.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña Incorrectas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                }
            }
            //control de excepciones con trycatch
            catch (Exception ex)
            {
                MessageBox.Show("Error al Procesar el Login\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContraseña.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
