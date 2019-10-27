using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practica_final
{
    public class Sala
    {

        public Sala(string nombre, int cantUser, Pelicula peli)
        {
            this.nombre = nombre;
            this.cantUser = cantUser;
            this.peli = peli;
        }
        public string nombre { get; set; }
        public int cantUser { get; set; }
        public const int maxUser = 15;
        public Pelicula peli { get; set; }

    }
}
