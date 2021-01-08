using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula pelicula = new Pelicula("Titanic", "James Cameron", 200, 16);

            int filas, columnas, numEsp, fila;
            Espectador e;
            char letra;
            double precio;

            Console.WriteLine("Introduce el numero de filas");
            filas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el numero de columnas");
            columnas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el numero precio de la entrada");
            precio = Double.Parse(Console.ReadLine());

            Cine cine = new Cine(filas, columnas, precio, pelicula);

            Console.WriteLine("Introduce el numero de espectadores a crear");
            numEsp = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Espectadores generados: ");
            for (int i = 0; i < numEsp && cine.haySitio(); i++)
            {
                e = new Espectador(Metodos.nombres[Metodos.generaNumeroEnteroAleatorio(0, Metodos.nombres.Length - 1)], //Nombre al azar
                    Metodos.generaNumeroEnteroAleatorio(10, 30), //Generamos una edad entre 10 y 30 años
                    Metodos.generaNumeroEnteroAleatorio(1, 10)); //Generamos el dinero entre 1 y 10 euros

                Console.WriteLine(e);
                do
                {

                    fila = Metodos.generaNumeroEnteroAleatorio(0, cine.getFilas() - 1);
                    letra = (char)Metodos.generaNumeroEnteroAleatorio('A', 'A' + (cine.getColumnas() - 1));

                } while (cine.haySitioButaca(fila, letra));
                //Si el espectador cumple con las condiciones
                if (cine.sePuedeSentar(e))
                {
                    e.pagar(cine.getPrecio()); //El espectador paga el precio de la entrada
                    cine.sentar(fila, letra, e); //El espectador se sienta
                }
            }

            Console.WriteLine("");
            cine.mostrar(); //Mostramos la información del cine, tambien se puede usar un toString

            Console.WriteLine("Fin");
        }
    }
}

