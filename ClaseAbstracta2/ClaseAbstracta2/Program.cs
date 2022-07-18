using System;

namespace ClaseAbstracta2
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante("118750349");
            estudiante.Descripcion();

            Empleado empleado = new Empleado(120);
            empleado.Descripcion();

            Docente docente = new Docente("Matematicas", 120);
            docente.Descripcion();
        }
    }
}
