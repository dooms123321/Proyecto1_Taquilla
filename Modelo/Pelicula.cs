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

    // IDs usados para guardar en base de datos
    public int Id_Genero { get; set; }
    public int Id_Clasificacion { get; set; }

    // Nombres usados solo para mostrar en pantalla
    public string Nombre_Genero { get; set; }
    public string Nombre_Clasificacion { get; set; }

    public Pelicula() { }

    public Pelicula(int id, string nombre, string sinopsis, int idGenero, string nombreGenero, int idClasificacion, string nombreClasificacion)
    {
        Id_Pelicula = id;
        Nombre = nombre;
        Sinopsis = sinopsis;
        Id_Genero = idGenero;
        Nombre_Genero = nombreGenero;
        Id_Clasificacion = idClasificacion;
        Nombre_Clasificacion = nombreClasificacion;
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


