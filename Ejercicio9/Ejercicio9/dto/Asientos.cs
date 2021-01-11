using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio9
{
	class Asientos
	{
		 static int fila = 0, col = 0;

		char[,] asientos = new char[Fila, Col];

		public static int Fila { get => fila; set => fila = value; }
		public static int Col { get => col; set => col = value; }

		public void comienzoSala() //Crea la sala de cine y la setea a "vacia"
		{
			int tamañ = asientos.GetLength(1);

			for (int i = 0; i < tamañ; i++)  //Define le tamaño y la "Setea" a "Vacia"
			{
				for (int j = 0; j < tamañ; j++)
				{
					asientos[i, j] = 'O';
				}
			}
		}
		public void mostrarCine() //Muestra de manera grafica las butacas(Libres y ocupadas) del cine por consola 
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

		
		public void llenarAsientos(Espectador espectador, Peliculas peliculas, Cine cine) //Rellena los asientos e indica si estan vacias o no, atributos 
			//espectador,peliculas y cine obtendran sus atributos desde sus respectivas clases;
		{
			Random random = new Random();
			int totalEntradas = Fila * Col;
			string NumAsiento;


			bool ocupado = false;
			if (espectador.Dinero >= cine.Precio && espectador.Edad >= peliculas.EdadMinima) //Requisitos para ver la pelicula
			{
				do
				{
					int asientoFila = random.Next(fila);  //Genera un random para asignar la fila del asiento
					int	asientoCol = random.Next(col);   //Genera un random para asignar la columna del asiento
					NumAsiento = Fila + "-" + Col;		//String para imprimir la localizacin del asiento
					if (asientos[asientoFila, asientoCol] == 'O') //Si asiento esta vacio 'O'
					{
						asientos[asientoFila, asientoCol] = 'X';  //Asigna propiedad, una vez seleccionada pasa a estar ocupada
						ocupado = true;
						totalEntradas--;
					}
					
				} while (!ocupado);
				
				Console.WriteLine(" A {0}, se la ha asignado el asiento {1} correctamente, Disfrute de la pelicula!", espectador.Nombre, NumAsiento);
			}
			else
			{
				Console.WriteLine(" {0} no cumple los requisitos para ver esta pelicula", espectador.Nombre);
			}
		}
	}
}
