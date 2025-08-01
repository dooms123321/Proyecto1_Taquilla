//Cesar Estrada Elias 0901-22-10153
//se cambio de categoriaDAO.cs a cineDAO.cs
using MySql.Data.MySqlClient;
using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Controlador
{
    public class CineDAO
    {
        private static string connectionString = "server=localhost; database=Taquilla; user=root; password=cesar123";
        public static List<Cine> ObtenerCine()
        {
            List<Cine> lista = new List<Cine>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM cine";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Cine cine = new Cine
                    (
                        reader.GetInt32("ID_Cine"),
                        reader.GetString("Nombre"),
                        reader.GetInt32("ID_plaza")
                    );
                    lista.Add(cine);
                }
            }
            return lista;
        }
        public static void InsertarCine(Cine cine)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO cine (ID_Cine, Nombre, ID_plaza) VALUES (@id, @nombre, @id_plaza)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", cine.ID_Cine);
                    cmd.Parameters.AddWithValue("@nombre", cine.Nombre);
                    cmd.Parameters.AddWithValue("@id_plaza", cine.ID_plaza);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void ActualizarCine(Cine cine)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE cine SET Nombre = @nombre, ID_plaza = @id_plaza WHERE ID_Cine = @idCine";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idCine", cine.ID_Cine);
                    cmd.Parameters.AddWithValue("@nombre", cine.Nombre);
                    cmd.Parameters.AddWithValue("@id_plaza", cine.ID_plaza);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Eliminar un cine por ID
        public static void EliminarCine(int idCine)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM cine WHERE ID_Cine = @idCine";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idCine", idCine);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}