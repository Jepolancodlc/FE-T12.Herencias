using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Cine
    {
        //Atributos
        private Asiento[][] asientos;
        private Pelicula pelicula;
        private double precio;

        //Construsctores
        public Cine()
        {
        }

        public Cine(int filas, int columnas, double precio, Pelicula pelicula)
        {
            asientos = new Asiento[filas][];
            this.Pelicula = pelicula;
            this.Precio = precio;
            rellenarButacas();
        }

        //Getters&Setters

        public double Precio { get => precio; set => precio = value; }
        internal Pelicula Pelicula { get => pelicula; set => pelicula = value; }
        internal Asiento[][] Asientos { get => asientos; set => asientos = value; }

        // Metodos
        public Asiento[][] getAsientos()
        {
            return asientos;
        }
        private void rellenarButacas()
        {
            int fila = asientos.Length;
            for (int i = 0; i < asientos.Length; i++)
            {
                for (int j = 0; j < asientos[0].Length; j++)
                {
                    asientos[i][j] = new Asiento((char)('A' + j), fila);
                }
                fila--; //Decremento la fila para actualizar la fila
            }
        }

        public bool haySitio()
        {
            for (int i = 0; i < asientos.Length; i++)
            {
                for (int j = 0; j < asientos.Length; j++)
                {
                    if (!asientos[i][j].ocupado())
                    {
                        return true;
                    }
                }
            }
            return false;
        }
       
        public Asiento getAsiento(int fila, char letra)
        {
            return asientos[asientos.Length - fila - 1][letra - 'A'];
        }

        public bool haySitioButaca(int fila, char letra)
        {
            return getAsiento(fila, letra).ocupado();
        }
        public bool sePuedeSentar(Espectador e)
        {
            return e.tieneDinero(precio) && e.tieneEdad(pelicula.getEdadMinima());
        }
        public void sentar(int fila, char letra, Espectador e)
        {
            getAsiento(fila, letra).setEspectador(e);
        }
        public double getPrecio()
        {
            return precio;
        }
        public int getFilas()
        {
            return asientos.Length;
        }
        public int getColumnas()
        {
            return asientos.Length;
        }

        public void mostrar()
        {

            Console.WriteLine("Información cine");
            Console.WriteLine("Pelicula reproducida: " + pelicula);
            Console.WriteLine("Precio entrada: " + precio);
            Console.WriteLine("");
            for (int i = 0; i < asientos.Length; i++)
            {
                for (int j = 0; j < asientos.Length; j++)
                {
                    Console.WriteLine(asientos[i][j]);
                }
                Console.WriteLine("");
            }
        }

        //tString
        public override string ToString()
        {
            return String.Format("Pelicula {0} | Precio {1} |",pelicula,precio);
        }
    }
}
