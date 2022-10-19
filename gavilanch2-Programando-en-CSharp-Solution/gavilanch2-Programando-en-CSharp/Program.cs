using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            5.ElevadoALa(3);

            Console.WriteLine(5.ElevadoALa(3));
            Console.WriteLine(7.ElevadoALa(2));
            Console.WriteLine(15.Doble());

            Console.Read();
        }
    }

    public static class IntegerExtensionMethods
    {
        public static double ElevadoALa(this int valor, int exponente)
        {
            return Math.Pow(valor, exponente);
        }

        public static double Doble(this int valor)
        {
            return valor * 2;
        }
    }
}