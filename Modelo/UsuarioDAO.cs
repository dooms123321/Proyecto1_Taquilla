using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaquillaPeliculas.Modelo;

namespace TaquillaPeliculas.Modelos
{
    public class UsuarioDAO
    {
        private static readonly string SQL_SELECT = "SELECT id_usuario, usuario, contraseña FROM usuario";
        private static readonly string SQL_INSERT = "INSERT INTO usuario(usuario, contraseña) VALUES(@usuario, @contraseña)";
        private static readonly string SQL_UPDATE = "UPDATE usuario SET usuario = @usuario, contraseña = @contraseña WHERE id_usuario = @id_usuario";
        private static readonly string SQL_DELETE = "DELETE FROM usuario WHERE id_usuario = @id_usuario";
        private static readonly string SQL_QUERY = "SELECT id_usuario, usuario, contraseña FROM usuario WHERE usuario = @usuario";

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
                            Id_usuario = reader.GetInt32("id_usuario"),
                            UsuarioNombre = reader.GetString("usuario"),
                            Contraseña = reader.GetString("contraseña")
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
                cmd.Parameters.AddWithValue("@usuario", usuario.UsuarioNombre);
                cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
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
                cmd.Parameters.AddWithValue("@usuario", usuario.UsuarioNombre);
                cmd.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@id_usuario", usuario.Id_usuario);
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
                cmd.Parameters.AddWithValue("@id_usuario", usuario.Id_usuario);
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
                cmd.Parameters.AddWithValue("@usuario", usuarioNombre);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            Id_usuario = reader.GetInt32("id_usuario"),
                            UsuarioNombre = reader.GetString("usuario"),
                            Contraseña = reader.GetString("contraseña")
                        };
                    }
                }
            }
            return usuario;
        }
    }
}