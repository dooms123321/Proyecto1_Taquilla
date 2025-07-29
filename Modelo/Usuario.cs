using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Modelo
{
    //constructores de Usuario con getter y setter
    public class Usuario
    {
        public int Id_usuario { get; set; }
        public string UsuarioNombre { get; set; }
        public string Contraseña { get; set; }

        //constructor vacio
        public Usuario() { }

        public Usuario(int id_usuario)
        {
            Id_usuario = id_usuario;
        }

        public Usuario(string usuarioNombre, string contraseña)
        {
            UsuarioNombre = usuarioNombre;
            Contraseña = contraseña;
        }

        public Usuario(int id_usuario, string usuarioNombre, string contraseña)
        {
            Id_usuario = id_usuario;
            UsuarioNombre = usuarioNombre;
            Contraseña = contraseña;
        }

        public override string ToString()
        {
            return $"Usuario{{Id_usuario={Id_usuario}, UsuarioNombre={UsuarioNombre}, Contraseña={Contraseña}}}";
        }
    }
}
