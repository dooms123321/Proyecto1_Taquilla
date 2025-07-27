using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaquillaPeliculas.Controlador
{
    public class UsuarioController
    {
        public int Id_usuario { get; set; }
        public string UsuarioNombre { get; set; }
        public string Contraseña { get; set; }

        // Constructor vacío
        public UsuarioController()
        {
        }

        // Constructor con solo ID
        public UsuarioController(int id_usuario)
        {
            Id_usuario = id_usuario;
        }

        //constructor con usuario y contraseña
        public UsuarioController(string usuarioNombre, string contraseña)
        {
            UsuarioNombre = usuarioNombre;
            Contraseña = contraseña;
        }

        //constructor con id, usuario y contraseña
        public UsuarioController(int id_usuario, string usuarioNombre, string contraseña)
        {
            Id_usuario = id_usuario;
            UsuarioNombre = usuarioNombre;
            Contraseña = contraseña;
        }

        // metodo to-string para depuración
        public override string ToString()
        {
            return $"Usuario{{id_usuario={Id_usuario}, usuarioNombre={UsuarioNombre}, contraseña={Contraseña}}}";
        }
    }
}


