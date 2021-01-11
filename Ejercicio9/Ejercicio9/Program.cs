using System;

namespace Ejercicio9
{
    class Program
    {

        static void Main(string[] args)

        {
            Espectador espectador = new Espectador("", 0, 0);
            Peliculas pelicula = new Peliculas("","",0,0);
            Asientos A = new Asientos();
            Cine cine = new Cine(pelicula,0);
            char[,] asientos = new char[8, 8];

            Console.WriteLine(cine);
            A.comienzoSala(asientos);

            for (int i = 0; i != 63; i++)
            {
                espectador = new Espectador("", 0, 0);
                Console.WriteLine(espectador);
                A.llenarAsientos(asientos, espectador, pelicula, cine);
            }
           
            A.mostrarCine(asientos);
        }
    }
}

