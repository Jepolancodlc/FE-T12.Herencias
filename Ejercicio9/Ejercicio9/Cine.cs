using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Cine
    {
        //Atributos
        private string pelicula = " ";
        private double precio = 0;

        //Construsctores
        public Cine()
        {
        }

        public Cine(string pelicula, double precio)
        {
            this.Pelicula = pelicula;
            this.Precio = precio;
        }

        //Getters&Setters

        public string Pelicula { get => pelicula; set => pelicula = value; }
        public double Precio { get => precio; set => precio = value; }

        //tString
        public override string ToString()
        {
            return String.Format("Pelicula {0} | Precio {1} |",pelicula,precio);
        }
    }
}
