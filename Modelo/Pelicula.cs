using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Modelo
{
    public class Pelicula
    {
        public int Id_Pelicula { get; set; }
        public string Nombre_Pelicula { get; set; }
        public string Descripcion { get; set; }

        public Pelicula(int id, string nombre, string descripcion)
        {
            Id_Pelicula = id;
            Nombre_Pelicula = nombre;
            Descripcion = descripcion;
        }
        public Pelicula() { }
    }
}


