using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < 1000; i++)
            {
                if (i == 999)
                {
                    throw new ApplicationException("No me gusta el 5");
                }
            }

            Console.Read();
        }

        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            return -1;
        }

        class Persona
        {
            public string nombre;
            public int edad;
        }
    }
}