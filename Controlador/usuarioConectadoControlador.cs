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
        // Variables estáticas que representan la sesión activa
        private static int idUsuario;
        private static string nombreUsuario;
        private static int? idCliente;
        private static int? idEmpleado;
        private static bool identificador; // true = empleado, false = cliente

        // Getters y setters
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

        public static int? IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public static int? IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public static bool Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }
    }
}
//namespace Proyecto_Taquilla.Controlador
//{
//    internal class usuarioConectadoControlador
//    {
//        //variables para almacenar id y nombre del usuario conectado dentro del sistema
//        private static int idUsuario;
//        private static string nombreUsuario;

//        //getter y setter para idUsuario y nombreUsuario
//        public static int IdUsuario
//        {
//            get { return idUsuario; }
//            set { idUsuario = value; }
//        }

//        public static string NombreUsuario
//        {
//            get { return nombreUsuario; }
//            set { nombreUsuario = value; }
//        }
//    }
//}
