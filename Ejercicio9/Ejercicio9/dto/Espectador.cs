using System;
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
        public Espectador() //Constructor por defecto
        {
        }

        public Espectador(string nombre, int edad, double dinero)
        {
            this.Nombre = generaNombre();
            this.Edad = generarEdad();
            this.Dinero = generarDinero();
        }

        //Getters&SetterS
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Dinero { get => dinero; set => dinero = value; }

        //Tstring
        public override string ToString()
        {
            return String.Format("\n Espectador----------- \n | Nombre: {0} | Edad: {1} años | Dinero {2}$|",nombre, edad,dinero);
        }

        //Metodos
                                                                                      //Arrays que contienen los nombres y apellidos a seleccionar
        string[] nombres = { "Juan", "Pedro", "Francisco", "Mia", "Alberto", "Maria", "Marco", "Teresa", "Federico", "Anais", "Andrea", "Isabel", "Emir", "Nate",
        "Juana","Elena","Carla","Carlos","Leon","Elisabeth","Lana","Camila","Camilo","Esteban","Alejandra","Raquel","Blanca","Manuel","Marta","Diego","John","Dimitri"};
        
        string[] apellido = { "Ramirez","De La Cruz","Polanco","Rodriguez","Juarez","Kafter","Messi","De La Vega","Duran","Dubinov","Ruiz","Petreski","Kalashnikov","Drake",
            "Falcon","Fragata","Chico","Bravo","Sanchez","Fernandez","Perez","Lopez","Alvarez","Flores","Smith","Johnson","Thompson","Makarov"};

        public string generaNombre() //Genera nombre y apellido al espectador
        {
            Random random = new Random();
     
            int t = nombres.Length, o = apellido.Length;
            string n = nombres[random.Next(t)]+" "+apellido[random.Next(o)] ;
            return n;
        }

        public double generarDinero() //Genera la cantidad de dinero del espectador
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * (50 - 0) + 0, 2);

        }

        public int generarEdad() //Genera la edad del espectador
        {
            Random random = new Random();
            return random.Next(3, 99); 
        }
    }
}
