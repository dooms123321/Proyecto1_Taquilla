using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//hecho por Kenph Luna 01/08/2025
namespace Proyecto_Taquilla.Modelo
{
    internal class Bitacora
    {
        public int IdBitacora { get; set; }
        public string FechaBitacora { get; set; }
        public string AccionBitacora { get; set; }
        public int IdUsuario { get; set; }
        public int IdAplicacion { get; set; }
        public string IpBitacora { get; set; }
        public string NombrePcBitacora { get; set; }

        // Constructor vacío
        public Bitacora() { }

        // demás consctructores 
        public Bitacora(int idBitacora)
        {
            IdBitacora = idBitacora;
        }

        public Bitacora(int idBitacora, string fechaBitacora)
        {
            IdBitacora = idBitacora;
            FechaBitacora = fechaBitacora;
        }

        public Bitacora(int idBitacora, string fechaBitacora, string accionBitacora)
        {
            IdBitacora = idBitacora;
            FechaBitacora = fechaBitacora;
            AccionBitacora = accionBitacora;
        }   

        public Bitacora(int idBitacora, string fechaBitacora, string accionBitacora, int idUsuario)
        {
            IdBitacora = idBitacora;
            FechaBitacora = fechaBitacora;
            AccionBitacora = accionBitacora;
            IdUsuario = idUsuario;
        }   
        public Bitacora(int idBitacora, string fechaBitacora, string accionBitacora, int idUsuario, int idAplicacion)
        {
            IdBitacora = idBitacora;
            FechaBitacora = fechaBitacora;
            AccionBitacora = accionBitacora;
            IdUsuario = idUsuario;
            IdAplicacion = idAplicacion;
        }
        public Bitacora(int idBitacora, string fechaBitacora, string accionBitacora, int idUsuario, int idAplicacion, string ipBitacora)
        {
            IdBitacora = idBitacora;
            FechaBitacora = fechaBitacora;
            AccionBitacora = accionBitacora;
            IdUsuario = idUsuario;
            IdAplicacion = idAplicacion;
            IpBitacora = ipBitacora;
        }
        public Bitacora(int idBitacora, string fechaBitacora, string accionBitacora, int idUsuario, int idAplicacion, string ipBitacora, string nombrePcBitacora)
        {
            IdBitacora = idBitacora;
            FechaBitacora = fechaBitacora;
            AccionBitacora = accionBitacora;
            IdUsuario = idUsuario;
            IdAplicacion = idAplicacion;
            IpBitacora = ipBitacora;
            NombrePcBitacora = nombrePcBitacora;
        }

        //constructor para registrar entrada sinn id
        public Bitacora(string fechaBitacora, string accionBitacora, int idUsuario, int idAplicacion, string ipBitacora, string nombrePcBitacora)
        {
            FechaBitacora = fechaBitacora;
            AccionBitacora = accionBitacora;
            IdUsuario = idUsuario;
            IdAplicacion = idAplicacion;
            IpBitacora = ipBitacora;
            NombrePcBitacora = nombrePcBitacora;
        }

        public override string ToString()
        {
            return $"Bitacora{{IdBitacora={IdBitacora}, FechaBitacora={FechaBitacora}, AccionBitacora={AccionBitacora}, IdUsuario={IdUsuario}, IdAplicacion={IdAplicacion}, IpBitacora={IpBitacora}, NombrePcBitacora={NombrePcBitacora}}}";
        }
    }
}
