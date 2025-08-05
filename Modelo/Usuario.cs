using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Proyecto_Taquilla.Modelo
{
    // Clase modelo para la tabla Usuarios
    public class Usuario
    {
        public int Id_usuario { get; set; }
        public string UsuarioNombre { get; set; }
        public string Contraseña { get; set; }
        public int? Id_cliente { get; set; }      // Nullable, ya que puede ser NULL si es empleado
        public int? Id_empleado { get; set; }     // Nullable, ya que puede ser NULL si es cliente
        public bool Identificador { get; set; }   // true = Empleado, false = Cliente

        // Constructor vacío
        public Usuario() { }

        // Constructor para autenticación básica
        public Usuario(string usuarioNombre, string contraseña)
        {
            UsuarioNombre = usuarioNombre;
            Contraseña = contraseña;
        }

        // Constructor completo
        public Usuario(int id_usuario, string usuarioNombre, string contraseña, int? id_cliente, int? id_empleado, bool identificador)
        {
            Id_usuario = id_usuario;
            UsuarioNombre = usuarioNombre;
            Contraseña = contraseña;
            Id_cliente = id_cliente;
            Id_empleado = id_empleado;
            Identificador = identificador;
        }

        public override string ToString()
        {
            return $"Usuario{{Id_usuario={Id_usuario}, UsuarioNombre={UsuarioNombre}, Contraseña={Contraseña}, Id_cliente={Id_cliente}, Id_empleado={Id_empleado}, Identificador={Identificador}}}";
        }
    }
}

//namespace Proyecto_Taquilla.Modelo
//{
//    //constructores de Usuario con getter y setter
//    public class Usuario
//    {
//        public int Id_usuario { get; set; }
//        public string UsuarioNombre { get; set; }
//        public string Contraseña { get; set; }

//        //constructor vacio
//        public Usuario() { }

//        public Usuario(int id_usuario)
//        {
//            Id_usuario = id_usuario;
//        }

//        public Usuario(string usuarioNombre, string contraseña)
//        {
//            UsuarioNombre = usuarioNombre;
//            Contraseña = contraseña;
//        }

//        public Usuario(int id_usuario, string usuarioNombre, string contraseña)
//        {
//            Id_usuario = id_usuario;
//            UsuarioNombre = usuarioNombre;
//            Contraseña = contraseña;
//        }

//        public override string ToString()
//        {
//            return $"Usuario{{Id_usuario={Id_usuario}, UsuarioNombre={UsuarioNombre}, Contraseña={Contraseña}}}";
//        }
//    }
//}
