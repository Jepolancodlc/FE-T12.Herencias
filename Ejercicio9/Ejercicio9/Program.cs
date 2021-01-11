using System;

namespace Ejercicio9
{
    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("Introdzca numero espectadores: ");
            int nE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*Recuerde: El numero de columnas no ha de ser mayor que el de filas*");
            Console.WriteLine("Introdzca numero de filas: ");
            Asientos.Fila = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdzca numero de columnas: ");
         
            Asientos.Col = Convert.ToInt32(Console.ReadLine());
           
            Espectador espectador = new Espectador();
            Peliculas pelicula = new Peliculas();
            Asientos A = new Asientos();
            Cine cine = new Cine(pelicula);
            Console.WriteLine(cine);

            A.comienzoSala();

            for (int i = 0; i != nE; i++)
            {
                espectador = new Espectador();
                Console.WriteLine(espectador);
                A.llenarAsientos(espectador, pelicula, cine);
            }
            A.mostrarCine();
        }
    }
}

