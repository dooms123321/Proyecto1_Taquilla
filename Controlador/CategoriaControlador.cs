using Proyecto_Taquilla.Modelo;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Taquilla.Controlador;
using System.Collections.Generic;

namespace Proyecto_Taquilla.Controlador
{
    public class CategoriaController
    {
        // Obtener todas las categorías desde la base de datos
        public List<Categoria> ObtenerTodasLasCategorias()
        {
            return CategoriaDAO.ObtenerCategorias();
        }

        // Crear una nueva categoría (con genero, clasificación, idioma)
        public void CrearCategoria(
            int idGenero,
            string nombreGenero,
            int idClasificacion,
            string clasificacion,
            string descripcionClasificacion,
            int idIdioma,
            bool doblada,
            bool subtitulos)
        {
            Categoria nueva = new Categoria(
                idGenero,
                nombreGenero,
                idClasificacion,
                clasificacion,
                descripcionClasificacion,
                idIdioma,
                doblada,
                subtitulos
            );

            CategoriaDAO.InsertarCategoria(nueva);
        }

        // Actualizar una categoría existente
        public void ActualizarCategoria(
            int idGenero,
            string nombreGenero,
            int idClasificacion,
            string clasificacion,
            string descripcionClasificacion,
            int idIdioma,
            bool doblada,
            bool subtitulos)
        {
            Categoria actualizada = new Categoria(
                idGenero,
                nombreGenero,
                idClasificacion,
                clasificacion,
                descripcionClasificacion,
                idIdioma,
                doblada,
                subtitulos
            );

            CategoriaDAO.ActualizarCategoria(actualizada);
        }

        // Eliminar una categoría (requiere pasar una instancia)
        public void EliminarCategoria(Categoria categoria)
        {
            CategoriaDAO.EliminarCategoria(categoria);
        }
    }
}
