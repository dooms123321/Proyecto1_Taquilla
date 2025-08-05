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
        // Incluir JOIN para obtener nombre del género y clasificación
        private static readonly string SQL_SELECT = @"SELECT p.ID_Pelicula, p.Nombre, p.Sinopsis, g.ID_Genero, g.Nombre_Genero, c.ID_Clasificacion, c.Descripcion
            FROM Pelicula p
            INNER JOIN Genero g ON p.ID_Genero = g.ID_Genero
            INNER JOIN Clasificacion_Edad c ON p.ID_Clasificacion = c.ID_Clasificacion";

        private static readonly string SQL_INSERT = @"INSERT INTO Pelicula (ID_Pelicula, Nombre, Sinopsis, ID_Genero, ID_Clasificacion) 
            VALUES (@id, @nombre, @sinopsis, @id_genero, @id_clasificacion)";
        private static readonly string SQL_UPDATE = @"UPDATE Pelicula SET Nombre = @nombre, Sinopsis = @sinopsis, ID_Genero = @id_genero, ID_Clasificacion = @id_clasificacion WHERE ID_Pelicula = @id";
        private static readonly string SQL_DELETE = "DELETE FROM Pelicula WHERE ID_Pelicula = @id";

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
                        {
                            Id_Pelicula = reader.GetInt32("ID_Pelicula"),
                            Nombre = reader.GetString("Nombre"),
                            Sinopsis = reader.GetString("Sinopsis"),

                            Id_Genero = reader.GetInt32("ID_Genero"),
                            Nombre_Genero = reader.GetString("Nombre_Genero"),

                            Id_Clasificacion = reader.GetInt32("ID_Clasificacion"),
                            Nombre_Clasificacion = reader.GetString("Descripcion")
                        };
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
                cmd.Parameters.AddWithValue("@id_genero", pelicula.Id_Genero);
                cmd.Parameters.AddWithValue("@id_clasificacion", pelicula.Id_Clasificacion);
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
                cmd.Parameters.AddWithValue("@id_genero", pelicula.Id_Genero);
                cmd.Parameters.AddWithValue("@id_clasificacion", pelicula.Id_Clasificacion);
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
