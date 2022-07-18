using System;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            Argentina argentina = new Argentina();
            argentina.Pizza();
            argentina.Empanadas();

            Italia italia = new Italia();
            italia.Pizza();
            italia.Empanadas();
        }
    }
}
