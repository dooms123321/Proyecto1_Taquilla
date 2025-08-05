using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaquillaPeliculas.Controlador
{
    public class UsuarioController
    {
        public List<Usuario> CargarUsuarios()
        {
            UsuarioDAO dao = new UsuarioDAO();
            return dao.Select();
        }

        public void AgregarUsuario(int id_usuario, string usuarioNombre, string contraseña, int? id_cliente, int? id_empleado, bool identificador)
        {
            Usuario nuevoUsuario = new Usuario
            {
                Id_usuario = id_usuario,
                UsuarioNombre = usuarioNombre,
                Contraseña = contraseña,
                Id_cliente = id_cliente,
                Id_empleado = id_empleado,
                Identificador = identificador
            };

            UsuarioDAO dao = new UsuarioDAO();
            dao.Insert(nuevoUsuario);
        }

        public void ActualizarUsuario(int id_usuario, string usuarioNombre, string contraseña, int? id_cliente, int? id_empleado, bool identificador)
        {
            Usuario usuarioActualizado = new Usuario
            {
                Id_usuario = id_usuario,
                UsuarioNombre = usuarioNombre,
                Contraseña = contraseña,
                Id_cliente = id_cliente,
                Id_empleado = id_empleado,
                Identificador = identificador
            };

            UsuarioDAO dao = new UsuarioDAO();
            dao.Update(usuarioActualizado);
        }

        public void EliminarUsuario(int id_usuario)
        {
            Usuario usuarioEliminar = new Usuario { Id_usuario = id_usuario };
            UsuarioDAO dao = new UsuarioDAO();
            dao.Delete(usuarioEliminar);
        }

        public Usuario ConsultarUsuario(string usuarioNombre)
        {
            UsuarioDAO dao = new UsuarioDAO();
            return dao.Query(usuarioNombre);
        }
    }
}
//namespace TaquillaPeliculas.Controlador
//{
//    public class UsuarioController
//    {
//        public List<Usuario> CargarUsuarios()
//        {
//            UsuarioDAO dao = new UsuarioDAO();
//            return dao.Select();
//        }

//        public void AgregarUsuario(int id_usuario, string usuarioNombre, string contraseña)
//        {
//            Usuario nuevoUsuario = new Usuario(id_usuario, usuarioNombre, contraseña);
//            UsuarioDAO dao = new UsuarioDAO();
//            dao.Insert(nuevoUsuario);
//        }

//        public void ActualizarUsuario(int id_usuario, string usuarioNombre, string contraseña)
//        {
//            Usuario usuarioActualizado = new Usuario(id_usuario, usuarioNombre, contraseña);
//            UsuarioDAO dao = new UsuarioDAO();
//            dao.Update(usuarioActualizado);
//        }

//        public void EliminarUsuario(int id_usuario)
//        {
//            Usuario usuarioEliminar = new Usuario { Id_usuario = id_usuario };
//            UsuarioDAO dao = new UsuarioDAO();
//            dao.Delete(usuarioEliminar);
//        }

//        public Usuario ConsultarUsuario(string usuarioNombre)
//        {
//            UsuarioDAO dao = new UsuarioDAO();
//            return dao.Query(usuarioNombre);
//        }
//    }
//}


