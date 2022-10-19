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
            double promedio = CalcularPromedio(numero1, numero2, numero3);


            Console.Read();
        }

        //Sobrecarga: Varios métodos pueden tener el mismo nombre siempre y cuando sus valores de entrada sean diferentes

        private static int CalcularPromedio(double numero1, double numero2, double numero3)
        {
            throw new NotImplementedException();
        }

        private static double CalcularPromedio(double numero1, double numero2, double numero3)
        {
            throw new NotImplementedException();
        }

        //private static double CalcularPromedio(int numero1, int numero2)
        //{
        //    throw new NotImplementedException();
        //}

        private static double CalcularPromedio(int numero1, int numero2)
        {
            return (numero1 + numero2) / 2.0;
        }

        private static double CalcularPromedio(double numero1, double numero2)
        {
            return (numero1 + numero2) / 2.0;
        }
    }
}