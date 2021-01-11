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
        public Peliculas() //Devuelve valores aleatorios segun su tipo 
        {
            this.Titulo = generaPelicula();   
            this.Director = "Michael Bay";   
            this.Duracion = generarDuracion();
            this.EdadMinima = generaEdadMinima();
        }

        //Get&Set
        public string Titulo { get => titulo; set => titulo = value; }
        public string Director { get => director; set => director = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public int EdadMinima { get => edadMinima; set => edadMinima = value; }
        
        //toString
        public override string ToString()
        {
            return String.Format("| Titulo: {0} | Director: {1} | Duracion: {2}h c| Edad Minima: {3}años",titulo,director,duracion,edadMinima);
        }

        //Metodos
        private string[] pelis = {"be baja de venganza", "El indomable Cazará","Alicia en el pais con un regimen totalitario de las Quesadillas","47 Samurais que si son samurais","Niños Grandes 2","Alguna pelicula aburrida","Donde estan las rubias 3",
        "Hoy no maññññaaana","Rocky 777","Otro dia mas siendo pobre","Pelicula: Default"};   //Nombres de peliculas a elegir

        private string generaPelicula()  //Escoge el titulo del la pelicula aleatoriamente
        {
            Random random = new Random();
            int t = pelis.Length;   
            string n = pelis[random.Next(t)]; //Aqui Escoge el titulo 
            return n;
        }

        private int generaEdadMinima() //Genera la edad minima para ver la pelicula
        {
            int[] eMinima = { 0, 7, 12, 16, 18, 21 };
            Random random = new Random();
            int t = eMinima.Length;
            int n = eMinima[random.Next(t)];  //Escoge edad minima 
            return n;
        }

        private double generarDuracion() //Genera la duracion de la pelicula
        {
            Random random = new Random();
            double minutos = Math.Round(random.NextDouble() * (0.60 - 0) + 0,2); //Genera los minutos del 0 a 0.60
            int horas = random.Next(1,3); //Genera las horas en un rango de 1-3 (Promedio de duracion de peliculas
            double duracion = horas + minutos; //Suma para generar la duracion total en formato 0:00 y devuelve 
            return duracion;
        }
    }
}
