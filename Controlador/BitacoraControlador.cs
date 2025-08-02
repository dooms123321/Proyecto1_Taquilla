using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//hecho por Kenph Luna 01/08/2025
namespace Proyecto_Taquilla.Controlador
{
    internal class BitacoraControlador
    {
        public int InsertBitacora(int codigoUsuario, int codigoAplicacion, string accion)
        {
            BitacoraDAO dao = new BitacoraDAO();
            return dao.InsertarBitacora(codigoUsuario, codigoAplicacion, accion);
        }

        public List<Bitacora> ObtenerBitacorasPorFechas(string fechaInicio, string fechaFin)
        {
            BitacoraDAO dao = new BitacoraDAO();
            return dao.ConsultarBitacorasPorFecha(fechaInicio, fechaFin);
        }
    }
}
