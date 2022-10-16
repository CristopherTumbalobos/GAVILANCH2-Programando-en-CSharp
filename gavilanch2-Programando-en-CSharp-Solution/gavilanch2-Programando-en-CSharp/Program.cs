using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona() { nombre = "Felipe", edad = 90 };
            persona = null;

            Nullable<int> numero = 45;
            numero = null;

            DateTime? fechaDeNacimiento = null;
            fechaDeNacimiento = new DateTime(2015, 1, 1);

            //HasValue: Verifica si tiene un valor
            if (numero.HasValue)
            {
                Console.WriteLine("El numero tiene valor");
            }

            if (fechaDeNacimiento.HasValue)
            {
                //Value: Valor de la variable
                CalcularEdad(fechaDeNacimiento.Value);
                Console.WriteLine("La fecha tiene valor");
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