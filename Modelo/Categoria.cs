using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Modelo
{
    public class Categoria
    {
        // Propiedades de Genero
        public int ID_Genero { get; set; }
        public string Nombre_Genero { get; set; }

        // Propiedades de Clasificación Edad
        public int ID_Clasificacion { get; set; }
        public string Clasificacion { get; set; }
        public string Descripcion_Clasificacion { get; set; }

        // Propiedades de Idioma
        public int ID_Idioma { get; set; }
        public bool Doblada { get; set; }
        public bool Subtitulos { get; set; }

        public Categoria() { }

        public Categoria(
            int idGenero,
            string nombreGenero,
            int idClasificacion,
            string clasificacion,
            string descripcionClasificacion,
            int idIdioma,
            bool doblada,
            bool subtitulos)
        {
            ID_Genero = idGenero;
            Nombre_Genero = nombreGenero;

            ID_Clasificacion = idClasificacion;
            Clasificacion = clasificacion;
            Descripcion_Clasificacion = descripcionClasificacion;

            ID_Idioma = idIdioma;
            Doblada = doblada;
            Subtitulos = subtitulos;
        }
    }
}