using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Metodos
    {
        public static readonly string[] nombres = { "Pedro", "Marta", "Manolo", "Paula" };

        public static int generaNumeroEnteroAleatorio(int minimo, int maximo)
        {
            Random rnd = new Random();
            int num = rnd.Next(minimo, maximo);
            return num;
        }
    }
}
