using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//codigo nuevo de la nueva base de datos
public class Pelicula
{
    public int Id_Pelicula { get; set; }
    public string Nombre { get; set; }
    public string Sinopsis { get; set; }

    public string Nombre_Genero { get; set; }
    public string Clasificacion { get; set; }

    public Pelicula() { }

    public Pelicula(int id, string nombre, string sinopsis, string genero, string clasificacion)
    {
        Id_Pelicula = id;
        Nombre = nombre;
        Sinopsis = sinopsis;
        Nombre_Genero = genero;
        Clasificacion = clasificacion;
    }
}



//namespace Proyecto_Taquilla.Modelo
//{
//    public class Pelicula
//    {
//        public int Id_Pelicula { get; set; }
//        public string Nombre_Pelicula { get; set; }
//        public string Descripcion { get; set; }

//        public Pelicula(int id, string nombre, string descripcion)
//        {
//            Id_Pelicula = id;
//            Nombre_Pelicula = nombre;
//            Descripcion = descripcion;
//        }
//        public Pelicula() { }
//    }
//}


