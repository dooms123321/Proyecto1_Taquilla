using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Taquilla.Modelo;
using System.Collections.Generic;

namespace Proyecto_Taquilla.Controlador
{
    public class PeliculaController
    {
        public List<Pelicula> ObtenerTodasLasPeliculas()
        {
            return PeliculaDAO.ObtenerPeliculas();
        }

        public void CrearPelicula(int id, string nombre, string descripcion)
        {
            Pelicula nueva = new Pelicula(id, nombre, descripcion);
            PeliculaDAO.InsertarPelicula(nueva);
        }

        public void ActualizarPelicula(int id, string nombre, string descripcion)
        {
            Pelicula actualizada = new Pelicula(id, nombre, descripcion);
            PeliculaDAO.ActualizarPelicula(actualizada);
        }

        public void EliminarPelicula(int id)
        {
            PeliculaDAO.EliminarPelicula(id);
        }
    }
}


