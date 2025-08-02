using MySql.Data.MySqlClient;
using Proyecto_Taquilla.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Hecho por Kenph Luna 01/08/2025
namespace Proyecto_Taquilla.Modelo
{
    internal class BitacoraDAO
    {
        private static readonly string SQL_SELECT = "SELECT bitid, bitfecha, bitaccion, usuid, aplid, bitip, bitnombrepc FROM bitacora";
        private static readonly string SQL_INSERT = "INSERT INTO bitacora(bitfecha, bitaccion, usuid, aplid, bitip, bitnombrepc) VALUES(@fecha, @accion, @usuario, @aplicacion, @ip, @pc)";
        private static readonly string SQL_QUERY = "SELECT bitid, bitfecha, bitaccion, usuid, aplid, bitip, bitnombrepc FROM bitacora WHERE bitfecha BETWEEN @inicio AND @fin";

        //obtiene la ip del equipo con un gethostentry
        private string ObtenerIP()
        {
            foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) // IPv4
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1"; // Valor por defecto si no encuentra ninguna IP válida
        }

        //obtenemos la info del pc
        private string ObtenerNombrePc()
        {
            return Environment.MachineName;
        }

        private string FechaActual()
        {
            return DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        public List<Bitacora> ObtenerBitacoras()
        {
            List<Bitacora> lista = new List<Bitacora>();

            using (var conn = Conexion.ObtenerConexion())
            {
                using (MySqlCommand cmd = new MySqlCommand(SQL_SELECT, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Bitacora
                        {
                            IdBitacora = reader.GetInt32("bitid"),
                            FechaBitacora = reader.GetString("bitfecha"),
                            AccionBitacora = reader.GetString("bitaccion"),
                            IdUsuario = reader.GetInt32("usuid"),
                            IdAplicacion = reader.GetInt32("aplid"),
                            IpBitacora = reader.GetString("bitip"),
                            NombrePcBitacora = reader.GetString("bitnombrepc")
                        });
                    }
                }
            }

            return lista;
        }

        public int InsertarBitacora(int idUsuario, int idAplicacion, string accion)
        {
            int filas = 0;
            try
            {
                string ip = ObtenerIP();
                string nombrePc = ObtenerNombrePc();

                using (var conn = Conexion.ObtenerConexion())
                {
                    using (MySqlCommand cmd = new MySqlCommand(SQL_INSERT, conn))
                    {
                        cmd.Parameters.AddWithValue("@fecha", FechaActual());
                        cmd.Parameters.AddWithValue("@accion", accion);
                        cmd.Parameters.AddWithValue("@usuario", idUsuario);
                        cmd.Parameters.AddWithValue("@aplicacion", idAplicacion);
                        cmd.Parameters.AddWithValue("@ip", ip);
                        cmd.Parameters.AddWithValue("@pc", nombrePc);

                        filas = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar bitácora: " + ex.Message);
            }

            return filas;
        }

        public List<Bitacora> ConsultarBitacorasPorFecha(string fechaInicio, string fechaFin)
        {
            List<Bitacora> lista = new List<Bitacora>();

            try
            {
                using (var conn = Conexion.ObtenerConexion())
                {

                    using (MySqlCommand cmd = new MySqlCommand(SQL_QUERY, conn))
                    {
                        cmd.Parameters.AddWithValue("@inicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@fin", fechaFin);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Bitacora
                                {
                                    IdBitacora = reader.GetInt32("bitid"),
                                    FechaBitacora = reader.GetDateTime("bitfecha").ToString("yyyy-MM-dd HH:mm:ss"),
                                    AccionBitacora = reader.GetString("bitaccion"),
                                    IdUsuario = reader.GetInt32("usuid"),
                                    IdAplicacion = reader.GetInt32("aplid"),
                                    IpBitacora = reader.GetString("bitip"),
                                    NombrePcBitacora = reader.GetString("bitnombrepc")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar bitácora: " + ex.Message);
            }


            return lista;
        }
    }
}
