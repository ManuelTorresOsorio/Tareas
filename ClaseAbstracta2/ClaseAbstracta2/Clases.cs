using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta2
{
    abstract class Persona
    {
        public abstract void Descripcion();

        
    }



    class Estudiante: Persona
    {
        public override void Descripcion()
        {
            Console.WriteLine("El estudiante Manuel cuyo numero de cedula es " + this.Cedula + " esta en clases");
        }

        public string Cedula { get; set; }

        public Estudiante(string cedula)
        {
            Cedula = cedula;
        }
    }

    class Empleado : Persona
    {
        public override void Descripcion()
        {
            Console.WriteLine("El empleado es un docente y gana "+this.Salario+"mil colones");
        }

        public int Salario { get; set; }

        public Empleado(int salario)
        {
            Salario = salario;
        }
    }

    class Docente: Empleado
    {
        public override void Descripcion()
        {
            Console.WriteLine("El docente imparte el curso de " + this.Curso + " y su salario es de " + this.Salario+"mil colones");
        }

        public string Curso { get; set; }

        public Docente (string curso, int salario): base(salario)
        {
            Curso = curso;
            Salario = salario;
        }
    }

}
