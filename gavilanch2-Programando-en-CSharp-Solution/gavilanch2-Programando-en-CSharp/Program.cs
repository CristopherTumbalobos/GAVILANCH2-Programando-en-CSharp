using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 5;
            double numero2 = 7;
            double numero3 = 10;
            double promedio = CalcularPromedio(4, 5, 6, 7, 3, 5, 7);
            Console.WriteLine(promedio);
        }

        //int[]: Arreglo de enteros
        private static double CalcularPromedio(params int[] numeros)
        {
            double suma = 0.0;
            foreach (var numero in numeros)
            {
                //suma = suma + numero;
                suma += numero;
            }
            return suma / numeros.Length;
        }
    }
}