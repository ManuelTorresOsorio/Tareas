using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    //Metodo Creacional Abstract Factory

    abstract class Pizzeria
    {
        public abstract void Pizza();
        public abstract void Empanadas();
    }


    class Argentina : Pizzeria
    {
        public override void Pizza()
        {
            Console.WriteLine("En la pizzeria Argentina se vende pizza cancha");
        }
        public override void Empanadas()
        {
            Console.WriteLine("En la pizzeria Argentina se venden empanadas de carne");
        }

    }

    class Italia : Pizzeria
    {
        public override void Pizza()
        {
            Console.WriteLine("En la pizzeria Italiana se vende pizza napolitana");
        }
        public override void Empanadas()
        {
            Console.WriteLine("En la pizzeria Argentina se venden empanadas de carne");
        }
    }
}

