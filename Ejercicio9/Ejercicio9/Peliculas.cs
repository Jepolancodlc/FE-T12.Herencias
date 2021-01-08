using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Peliculas
    {
        //Atributos

        private string titulo = "", director="";
        private double duracion = 0;
        private int edadMinima=0;

        //Constructores
        public Peliculas()
        {
        }

        public Peliculas(string titulo, string director, double duracion, int edadMinima)
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

        //Tstrin
        public override string ToString()
        {
            return String.Format("Titulo {0} | Director {1} | Duracion {2}| Edad Minima {3}",titulo,director,duracion,edadMinima);
        }
    }
}
