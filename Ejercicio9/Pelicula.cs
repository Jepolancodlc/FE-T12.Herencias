using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Pelicula
    {
        //Atributos

        private string titulo, director;
        private double duracion;
        private int edadMinima;

        //Constructores
        public Pelicula()
        {
        }

        public Pelicula(string titulo, string director, double duracion, int edadMinima)
        {
            this.Titulo = titulo;
            this.Director = director;
            this.Duracion = duracion;
            this.EdadMinima = edadMinima;
        }

        //G&S
        public string Titulo { get => titulo; set => titulo = value; }
        public string Director { get => director; set => director = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public int EdadMinima { get => edadMinima; set => edadMinima = value; }
        public int getEdadMinima()
        {
            return edadMinima;
        }

        //Tstrin
        public override string ToString()
        {
            return String.Format("Titulo {0} | Director {1} | Duracion {2}| Edad Minima {3}",titulo,director,duracion,edadMinima);
        }
    }
}
