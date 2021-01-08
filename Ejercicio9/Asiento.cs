using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Asiento
    {
        private char letra;
        private int fila;
        private Espectador espectador; // Informacion el espectador que esta sentado, si no hay es null

        // Constructores
        public Asiento()
        {
        }
        public Asiento(char letra, int fila)
        {
            this.letra = letra;
            this.fila = fila;
            this.espectador = null; //al iniciar el asiento, no habrá nadie sentado
        }

        // Getters y Setters
        public char Letra { get => letra; set => letra = value; }
        public int Fila { get => fila; set => fila = value; }
        internal Espectador Espectador { get => espectador; set => espectador = value; }
        public void setEspectador(Espectador espectador)
        {
            this.espectador = espectador;
        }

        // Metodo
        public bool ocupado()
        {
            return espectador != null;
        }

        // ToString
        public override string ToString()
        {
            if (ocupado())
            {
                return "Asiento: " + fila + letra + " y " + espectador;
            }
            return "Asiento: " + fila + letra + " y este asiento esta vacio";
        }
    }
}
