using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_final
{
    /*
     --------------------------
     Clase Pelicula , en la cual almacenamos toda la informacion de dicha entidad.
     */
    public class Pelicula
    {
        public Pelicula(int id, string nombre, double precio,string resena)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.resena = resena;
        }
        public int id { get; set; } //propiedad id, para identificar cada pelicula de otra.
        public string resena { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
    }
    
}
