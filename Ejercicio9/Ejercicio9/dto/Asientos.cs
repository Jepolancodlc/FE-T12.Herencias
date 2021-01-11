using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio9
{
    class Asientos
	{
		
		
		public void comienzoSala(char[,] asientos) //Crea la sala de cine y la setea a "vacia"
		{
			int tamañ = asientos.GetLength(1);

			for (int i = 0; i != tamañ; i++)  //Define le tamaño y la "Setea" a "Vacia"
			{
				for (int j = 0; j != tamañ; j++)
				{
					asientos[i, j] = 'O';
				}
			}

		}

		public void mostrarCine(char[,] asientos) //Muestra de manera grafica las butacas(Libres y ocupadas) del cine por consola 
		{
			int tamañ = asientos.GetLength(1);
			for (int f = 0; f < tamañ; f++)
			{
				Console.WriteLine("");

				for (int c = 0; c < tamañ; c++)
				{
					Console.Write(" [" + asientos[f, c] + "]");
				}

			}
		}

		public void llenarAsientos(char[,] asientos, Espectador espectador, Peliculas peliculas, Cine cine) //Rellena los asientos e indica si estan vacias o no 
		{
			Random random = new Random();
			int fila = 0, col = 0, ventas = 0;
			bool ocupado = false;
			if (espectador.Dinero >= cine.Precio ) //&& espectador.Edad >= peliculas.EdadMinima) //Requisitos para ver la pelicula
			{
                do
                {
					fila = random.Next(8);
					col = random.Next(8);
					
						if (asientos[fila, col] == 'O')
						{
							asientos[fila, col] = 'X';  //Asigna propiedad, una vez seleccionada pasa a estar ocupada
							ocupado = true;
							ventas++;

						}
					
				} while (!ocupado);


				Console.WriteLine(" A {0}, se la ha asignado el asiento su asiento correctamente, Disfrute de la pelicula!", espectador.Nombre);
			}
			else
			{
				Console.WriteLine(" {0} no cumple los requisitos para ver esta pelicula", espectador.Nombre);
			}

		}
			

		/* Booleno para comprobar si esta lleno el cine, <No funciona>
		
		bool estaLLeno(char[,] asientos)
        {
			int cont=0;
			char o = 'O';
			bool v = false;
			for (int i = 0; i != asientos.GetLength(0); i++)  //Define le tamaño y la "Setea" a "Vacia"
			{
				for (int j = 0; j != asientos.GetLength(1); j++)
				{
					if (o.Equals(asientos[i, j]))
					{
						cont++;

					}
				}
			}

            if (cont >=1)
            {
				v = false;
            }
            else
            {
				v = true;
            }

			return v;
		}
			*/
	}
}
