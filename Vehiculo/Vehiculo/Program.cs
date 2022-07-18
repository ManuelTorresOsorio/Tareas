using System;

namespace Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo("135F84", "Gris", 9696);
            Random z = new Random();
            Random p = new Random();

            vehiculo.Arrancar();
            Console.WriteLine("La velocidad del vehiculo es de "+ vehiculo.Velocidad(z.Next(1,200))+" KPH");
            Console.WriteLine("La cantidad de pasajeros en el vehiculo es de " + vehiculo.Pasajeros(p.Next(1, 4)));
            vehiculo.Apagar();
        }
    }
}
