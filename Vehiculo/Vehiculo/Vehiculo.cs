using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculo
{
    class Vehiculo
    {
        //Atributos
        public string Placa { get; set; }
        public string Color { get; set; }
        public int Motor { get; set; }

        //Constructor
        public  Vehiculo(string placa, string color, int motor)
        {
            Placa = placa;
            Color = color;
            Motor = motor;
        }
       
        //Metodos
        public void Arrancar()
        {
            Console.WriteLine("El vehiculo esta encendido");
        }
        public void Apagar()
        {
            Console.WriteLine("El vehiculo esta apagado");
        }
           
        public int Velocidad(int Velocidad)
        {
            return Velocidad;
            
        }
        public int Pasajeros(int Pasajeros)
        {
            return Pasajeros;
        }
    }
}
