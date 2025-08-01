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
    {                                                                                             //cambiar contraseña Cronopio0
        private static string connectionString = "server=localhost; database=Taquilla; user=root; password=cesar123;";

        public static List<Pelicula> ObtenerPeliculas()
        {
            List<Pelicula> lista = new List<Pelicula>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM pelicula";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pelicula p = new Pelicula
                    (
                        reader.GetInt32("id_pelicula"),
                        reader.GetString("nombre_pelicula"),
                        reader.GetString("descripcion")
                    );
                    lista.Add(p);
                }
            }
            return lista;
        }

        public static void InsertarPelicula(Pelicula pelicula)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO pelicula (id_pelicula, nombre_pelicula, descripcion) VALUES (@id, @nombre, @descripcion)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", pelicula.Id_Pelicula);
                    cmd.Parameters.AddWithValue("@nombre", pelicula.Nombre_Pelicula);
                    cmd.Parameters.AddWithValue("@descripcion", pelicula.Descripcion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ActualizarPelicula(Pelicula pelicula)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE pelicula SET nombre_pelicula = @nombre, descripcion = @descripcion WHERE id_pelicula = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", pelicula.Nombre_Pelicula);
                cmd.Parameters.AddWithValue("@descripcion", pelicula.Descripcion);
                cmd.Parameters.AddWithValue("@id", pelicula.Id_Pelicula);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    MessageBox.Show("No se encontró ninguna película con ese ID");
                }
            }
        }


        public static void EliminarPelicula(int id_pelicula)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM pelicula WHERE id_pelicula = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id_pelicula);
                cmd.ExecuteNonQuery();
            }
        }
    }
}