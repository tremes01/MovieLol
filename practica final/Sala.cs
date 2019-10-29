using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practica_final
{
    /*Aqui almancenaremos todas las salas de cine*/ //Creando una instancia u objeto
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
        public Pelicula peli { get; set; }/*Aqui almancenaremos las referencias a la peliculas que tenga esta sala.*/

    }
}
