﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Espectador

    {

        //Atributos
        private string nombre="";
        private int edad=0;
        private double dinero=0;

        //Constructores
        public Espectador()
        {
        }

        public Espectador(string nombre, int edad, double dinero)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Dinero = dinero;
        }

        //Getters&SetterS
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Dinero { get => dinero; set => dinero = value; }

        //Tstring
        public override string ToString()
        {
            return String.Format("Nombre {0} | Edad {1} | Dinero {2}|", nombre, edad, dinero);
        }
    }
}