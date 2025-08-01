//Cesar Astrada Elias 0901-22-10153
//Antes era CategoriaController.cs ahorda se cambio a CineController.cs
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
    public class CineController
    {
        public List<Cine> ObtenerTodosLosCines()
        {
            return CineDAO.ObtenerCine();
        }
        //se envia el objeto no argumentos
        public void InsertarCine(Cine cine)
        {
            CineDAO.InsertarCine(cine);
        }
        //actualizarCine
        public void ActualizarCine(int id_cine, string nombre, int id_plaza)
        {
            Cine actualizado = new Cine(id_cine, nombre, id_plaza);
            CineDAO.ActualizarCine(actualizado);
        }
        //EliminarCine por ID
        public void EliminarCine(int idCine)
        {
            CineDAO.EliminarCine(idCine);
        }
    }
}