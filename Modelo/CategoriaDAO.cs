//Cesar Estrada Elias 0901-22-10153
using MySql.Data.MySqlClient;
using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Controlador
{
    public class CategoriaDAO
    {                                                                                             //cambiar contraseña Cronopio0
        private static string connectionString = "server=localhost; database=Taquilla; user=root; password=Cronopio0;";

        public static List<Categoria> ObtenerCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        g.ID_Genero, g.Nombre_Genero,
                        c.ID_Clasificacion, c.Clasificacion, c.Descripcion,
                        i.ID_Idioma, i.Doblada, i.Subtitulos
                    FROM Genero g
                    JOIN Clasificacion_Edad c ON g.ID_Genero = c.ID_Clasificacion
                    JOIN Idioma i ON c.ID_Clasificacion = i.ID_Idioma";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Categoria cat = new Categoria(
                            reader.GetInt32("ID_Genero"),
                            reader.GetString("Nombre_Genero"),
                            reader.GetInt32("ID_Clasificacion"),
                            reader.GetString("Clasificacion"),
                            reader.GetString("Descripcion"),
                            reader.GetInt32("ID_Idioma"),
                            reader.GetBoolean("Doblada"),
                            reader.GetBoolean("Subtitulos")
                        );

                        lista.Add(cat);
                    }
                }
            }

            return lista;
        }

        public static void InsertarCategoria(Categoria categoria)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Inserta en Genero
                string sqlGenero = "INSERT INTO Genero (ID_Genero, Nombre_Genero) VALUES (@idGenero, @nombreGenero)";
                using (MySqlCommand cmd = new MySqlCommand(sqlGenero, conn))
                {
                    cmd.Parameters.AddWithValue("@idGenero", categoria.ID_Genero);
                    cmd.Parameters.AddWithValue("@nombreGenero", categoria.Nombre_Genero);
                    cmd.ExecuteNonQuery();
                }

                // Inserta en Clasificacion_Edad
                string sqlClasif = "INSERT INTO Clasificacion_Edad (ID_Clasificacion, Clasificacion, Descripcion) VALUES (@idClasif, @clasif, @desc)";
                using (MySqlCommand cmd = new MySqlCommand(sqlClasif, conn))
                {
                    cmd.Parameters.AddWithValue("@idClasif", categoria.ID_Clasificacion);
                    cmd.Parameters.AddWithValue("@clasif", categoria.Clasificacion);
                    cmd.Parameters.AddWithValue("@desc", categoria.Descripcion_Clasificacion);
                    cmd.ExecuteNonQuery();
                }

                // Inserta en Idioma
                string sqlIdioma = "INSERT INTO Idioma (ID_Idioma, Doblada, Subtitulos) VALUES (@idIdioma, @doblada, @subtitulos)";
                using (MySqlCommand cmd = new MySqlCommand(sqlIdioma, conn))
                {
                    cmd.Parameters.AddWithValue("@idIdioma", categoria.ID_Idioma);
                    cmd.Parameters.AddWithValue("@doblada", categoria.Doblada);
                    cmd.Parameters.AddWithValue("@subtitulos", categoria.Subtitulos);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ActualizarCategoria(Categoria categoria)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Actualizar Genero
                string sqlGenero = "UPDATE Genero SET Nombre_Genero = @nombreGenero WHERE ID_Genero = @idGenero";
                using (MySqlCommand cmd = new MySqlCommand(sqlGenero, conn))
                {
                    cmd.Parameters.AddWithValue("@idGenero", categoria.ID_Genero);
                    cmd.Parameters.AddWithValue("@nombreGenero", categoria.Nombre_Genero);
                    cmd.ExecuteNonQuery();
                }

                // Actualizar Clasificacion
                string sqlClasif = "UPDATE Clasificacion_Edad SET Clasificacion = @clasif, Descripcion = @desc WHERE ID_Clasificacion = @idClasif";
                using (MySqlCommand cmd = new MySqlCommand(sqlClasif, conn))
                {
                    cmd.Parameters.AddWithValue("@idClasif", categoria.ID_Clasificacion);
                    cmd.Parameters.AddWithValue("@clasif", categoria.Clasificacion);
                    cmd.Parameters.AddWithValue("@desc", categoria.Descripcion_Clasificacion);
                    cmd.ExecuteNonQuery();
                }

                // Actualizar Idioma
                string sqlIdioma = "UPDATE Idioma SET Doblada = @doblada, Subtitulos = @subtitulos WHERE ID_Idioma = @idIdioma";
                using (MySqlCommand cmd = new MySqlCommand(sqlIdioma, conn))
                {
                    cmd.Parameters.AddWithValue("@idIdioma", categoria.ID_Idioma);
                    cmd.Parameters.AddWithValue("@doblada", categoria.Doblada);
                    cmd.Parameters.AddWithValue("@subtitulos", categoria.Subtitulos);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void EliminarCategoria(Categoria categoria)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Elimina de Idioma
                string sqlIdioma = "DELETE FROM Idioma WHERE ID_Idioma = @idIdioma";
                using (MySqlCommand cmd = new MySqlCommand(sqlIdioma, conn))
                {
                    cmd.Parameters.AddWithValue("@idIdioma", categoria.ID_Idioma);
                    cmd.ExecuteNonQuery();
                }

                // Elimina de Clasificación
                string sqlClasif = "DELETE FROM Clasificacion_Edad WHERE ID_Clasificacion = @idClasif";
                using (MySqlCommand cmd = new MySqlCommand(sqlClasif, conn))
                {
                    cmd.Parameters.AddWithValue("@idClasif", categoria.ID_Clasificacion);
                    cmd.ExecuteNonQuery();
                }

                // Elimina de Genero
                string sqlGenero = "DELETE FROM Genero WHERE ID_Genero = @idGenero";
                using (MySqlCommand cmd = new MySqlCommand(sqlGenero, conn))
                {
                    cmd.Parameters.AddWithValue("@idGenero", categoria.ID_Genero);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
