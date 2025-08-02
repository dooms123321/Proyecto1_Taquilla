using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hecho por Kenph Luna 01/08/2025
namespace Proyecto_Taquilla.Controlador
{
    internal class usuarioConectadoControlador
    {
        //variables para almacenar id y nombre del usuario conectado dentro del sistema
        private static int idUsuario;
        private static string nombreUsuario;

        //getter y setter para idUsuario y nombreUsuario
        public static int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public static string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
    }
}
