using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Taquilla.Modelo;
using Proyecto_Taquilla.Controlador;

namespace Proyecto_Taquilla.Modelo
{
    public class UsuarioDAO
    {
        // Sentencias SQL con nombres de columnas corregidos según la base de datos
        private static readonly string SQL_SELECT = @"
            SELECT ID_Usuario, Nombre_Usuario, Contrasena, ID_Cliente, ID_Empleado, Identificador 
            FROM Usuarios";

        private static readonly string SQL_INSERT = @"
            INSERT INTO Usuarios (ID_Usuario, Nombre_Usuario, Contrasena, ID_Cliente, ID_Empleado, Identificador)
            VALUES (@ID_Usuario, @Nombre_Usuario, @Contrasena, @ID_Cliente, @ID_Empleado, @Identificador)";

        private static readonly string SQL_UPDATE = @"
            UPDATE Usuarios SET 
                Nombre_Usuario = @Nombre_Usuario, 
                Contrasena = @Contrasena, 
                ID_Cliente = @ID_Cliente, 
                ID_Empleado = @ID_Empleado, 
                Identificador = @Identificador 
            WHERE ID_Usuario = @ID_Usuario";

        private static readonly string SQL_DELETE = "DELETE FROM Usuarios WHERE ID_Usuario = @ID_Usuario";

        private static readonly string SQL_QUERY = @"
            SELECT ID_Usuario, Nombre_Usuario, Contrasena, ID_Cliente, ID_Empleado, Identificador 
            FROM Usuarios 
            WHERE Nombre_Usuario = @Nombre_Usuario";

        public List<Usuario> Select()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario
                        {
                            Id_usuario = reader.GetInt32("ID_Usuario"),
                            UsuarioNombre = reader.GetString("Nombre_Usuario"),
                            Contraseña = reader.GetString("Contrasena"),
                            Id_cliente = reader.IsDBNull(reader.GetOrdinal("ID_Cliente")) ? null : reader.GetInt32("ID_Cliente"),
                            Id_empleado = reader.IsDBNull(reader.GetOrdinal("ID_Empleado")) ? null : reader.GetInt32("ID_Empleado"),
                            Identificador = reader.GetBoolean("Identificador")
                        };
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }

        public int Insert(Usuario usuario)
        {
            int filasAfectadas = 0;
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT, conn);
                cmd.Parameters.AddWithValue("@ID_Usuario", usuario.Id_usuario);
                cmd.Parameters.AddWithValue("@Nombre_Usuario", usuario.UsuarioNombre);
                cmd.Parameters.AddWithValue("@Contrasena", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@ID_Cliente", (object)usuario.Id_cliente ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ID_Empleado", (object)usuario.Id_empleado ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Identificador", usuario.Identificador);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            return filasAfectadas;
        }

        public int Update(Usuario usuario)
        {
            int filasAfectadas = 0;
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE, conn);
                cmd.Parameters.AddWithValue("@Nombre_Usuario", usuario.UsuarioNombre);
                cmd.Parameters.AddWithValue("@Contrasena", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@ID_Cliente", (object)usuario.Id_cliente ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ID_Empleado", (object)usuario.Id_empleado ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Identificador", usuario.Identificador);
                cmd.Parameters.AddWithValue("@ID_Usuario", usuario.Id_usuario);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            return filasAfectadas;
        }

        public int Delete(Usuario usuario)
        {
            int filasAfectadas = 0;
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE, conn);
                cmd.Parameters.AddWithValue("@ID_Usuario", usuario.Id_usuario);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            return filasAfectadas;
        }

        public Usuario Query(string usuarioNombre)
        {
            Usuario usuario = null;
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_QUERY, conn);
                cmd.Parameters.AddWithValue("@Nombre_Usuario", usuarioNombre);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            Id_usuario = reader.GetInt32("ID_Usuario"),
                            UsuarioNombre = reader.GetString("Nombre_Usuario"),
                            Contraseña = reader.GetString("Contrasena"),
                            Id_cliente = reader.IsDBNull(reader.GetOrdinal("ID_Cliente")) ? null : reader.GetInt32("ID_Cliente"),
                            Id_empleado = reader.IsDBNull(reader.GetOrdinal("ID_Empleado")) ? null : reader.GetInt32("ID_Empleado"),
                            Identificador = reader.GetBoolean("Identificador")
                        };
                    }
                }
            }
            return usuario;
        }
    }
}
//namespace Proyecto_Taquilla.Modelo
//{
//    public class UsuarioDAO
//    {
//        private static readonly string SQL_SELECT = "SELECT id_usuario, usuario, contraseña FROM usuario";
//        private static readonly string SQL_INSERT = "INSERT INTO usuario(id_usuario, usuario, contraseña) VALUES(@id_usuario, @usuario, @contraseña)";
//        private static readonly string SQL_UPDATE = "UPDATE usuario SET usuario = @usuario, contraseña = @contraseña WHERE id_usuario = @id_usuario";
//        private static readonly string SQL_DELETE = "DELETE FROM usuario WHERE id_usuario = @id_usuario";
//        private static readonly string SQL_QUERY = "SELECT id_usuario, usuario, contraseña FROM usuario WHERE usuario = @usuario";

//        public List<Usuario> Select()
//        {
//            List<Usuario> usuarios = new List<Usuario>();
//            using (var conn = Conexion.ObtenerConexion())
//            {
//                MySqlCommand cmd = new MySqlCommand(SQL_SELECT, conn);
//                using (MySqlDataReader reader = cmd.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        Usuario usuario = new Usuario
//                        {
//                            Id_usuario = reader.GetInt32("id_usuario"),
//                            UsuarioNombre = reader.GetString("usuario"),
//                            Contraseña = reader.GetString("contraseña")
//                        };
//                        usuarios.Add(usuario);
//                    }
//                }
//            }
//            return usuarios;
//        }

//        public int Insert(Usuario usuario)
//        {
//            int filasAfectadas = 0;
//            using (var conn = Conexion.ObtenerConexion())
//            {
//                MySqlCommand cmd = new MySqlCommand(SQL_INSERT, conn);
//                cmd.Parameters.AddWithValue("@id_usuario", usuario.Id_usuario);
//                cmd.Parameters.AddWithValue("@usuario", usuario.UsuarioNombre);
//                cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
//                filasAfectadas = cmd.ExecuteNonQuery();
//            }
//            return filasAfectadas;
//        }

//        public int Update(Usuario usuario)
//        {
//            int filasAfectadas = 0;
//            using (var conn = Conexion.ObtenerConexion())
//            {
//                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE, conn);
//                cmd.Parameters.AddWithValue("@usuario", usuario.UsuarioNombre);
//                cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
//                cmd.Parameters.AddWithValue("@id_usuario", usuario.Id_usuario);
//                filasAfectadas = cmd.ExecuteNonQuery();
//            }
//            return filasAfectadas;
//        }

//        public int Delete(Usuario usuario)
//        {
//            int filasAfectadas = 0;
//            using (var conn = Conexion.ObtenerConexion())
//            {
//                MySqlCommand cmd = new MySqlCommand(SQL_DELETE, conn);
//                cmd.Parameters.AddWithValue("@id_usuario", usuario.Id_usuario);
//                filasAfectadas = cmd.ExecuteNonQuery();
//            }
//            return filasAfectadas;
//        }

//        public Usuario Query(string usuarioNombre)
//        {
//            Usuario usuario = null;
//            using (var conn = Conexion.ObtenerConexion())
//            {
//                MySqlCommand cmd = new MySqlCommand(SQL_QUERY, conn);
//                cmd.Parameters.AddWithValue("@usuario", usuarioNombre);
//                using (MySqlDataReader reader = cmd.ExecuteReader())
//                {
//                    if (reader.Read())
//                    {
//                        usuario = new Usuario
//                        {
//                            Id_usuario = reader.GetInt32("id_usuario"),
//                            UsuarioNombre = reader.GetString("usuario"),
//                            Contraseña = reader.GetString("contraseña")
//                        };
//                    }
//                }
//            }
//            return usuario;
//        }
//    }
//}