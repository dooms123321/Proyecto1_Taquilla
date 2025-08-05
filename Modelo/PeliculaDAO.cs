using MySql.Data.MySqlClient;
using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Taquilla.Controlador;
namespace Proyecto_Taquilla.Modelo
{
    public class PeliculaDAO
    {
        private static readonly string SQL_SELECT = "SELECT ID_Pelicula, Nombre, Sinopsis FROM pelicula";

        private static readonly string SQL_INSERT = @"
            INSERT INTO pelicula (ID_Pelicula, Nombre, Sinopsis)
            VALUES (@id, @nombre, @sinopsis)";

        private static readonly string SQL_UPDATE = @"
            UPDATE pelicula SET 
                Nombre = @nombre, 
                Sinopsis = @sinopsis 
            WHERE ID_Pelicula = @id";

        private static readonly string SQL_DELETE = "DELETE FROM pelicula WHERE ID_Pelicula = @id";

        public static List<Pelicula> ObtenerPeliculas()
        {
            List<Pelicula> lista = new List<Pelicula>();
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pelicula p = new Pelicula
                        (
                            reader.GetInt32("ID_Pelicula"),
                            reader.GetString("Nombre"),
                            reader.GetString("Sinopsis")
                        );
                        lista.Add(p);
                    }
                }
            }
            return lista;
        }

        public static void InsertarPelicula(Pelicula pelicula)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT, conn);
                cmd.Parameters.AddWithValue("@id", pelicula.Id_Pelicula);
                cmd.Parameters.AddWithValue("@nombre", pelicula.Nombre);
                cmd.Parameters.AddWithValue("@sinopsis", pelicula.Sinopsis);
                cmd.ExecuteNonQuery();
            }
        }

        public static void ActualizarPelicula(Pelicula pelicula)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE, conn);
                cmd.Parameters.AddWithValue("@nombre", pelicula.Nombre);
                cmd.Parameters.AddWithValue("@sinopsis", pelicula.Sinopsis);
                cmd.Parameters.AddWithValue("@id", pelicula.Id_Pelicula);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    System.Windows.Forms.MessageBox.Show("No se encontró ninguna película con ese ID");
                }
            }
        }

        public static void EliminarPelicula(int id_pelicula)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE, conn);
                cmd.Parameters.AddWithValue("@id", id_pelicula);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
