using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Cine 
    {
        //Atributos
        private Peliculas pelicula;
        private double precio = 0;

        //Construsctores
        public Cine(Peliculas pelicula)
        {
            this.Pelicula = pelicula;
            this.precio = generarPrecio();
        }
        //Getters&Setters
        public double Precio { get => precio; set => precio = value; }
        public Peliculas Pelicula { get => pelicula; set => pelicula = value; }

        //tString
        public override string ToString()
        {
            return String.Format(" Pelicula---------\n {0} | Precio {1}$ |", Pelicula, precio);
        }

        public double generarPrecio()
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * (12 - 3) + 3, 2);
        }
    }
}
