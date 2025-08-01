//antes era categoria.cs se cambio a cine
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Modelo
{
    public class Cine
    {
        public int ID_Cine { get; set; }
        public string Nombre { get; set; }
        public int ID_plaza { get; set; }
        public Cine(int id_cine, string nombre, int id_plaza)
        {
            ID_Cine = id_cine;
            this.Nombre = nombre;
            ID_plaza = id_plaza;
        }
        public Cine() { }
    }
}