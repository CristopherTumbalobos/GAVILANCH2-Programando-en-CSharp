using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio11
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 11: Escribir un método que acepte un datetime que represente la fecha de nacimiento de una persona y retornar su edad al día de hoy.");
            Console.WriteLine("");

            Console.WriteLine("Ingrese su fecha de nacimiento en formato dd/MM/yyyy: ");
            string fechaNacString = Console.ReadLine();
            DateTime fechaNacDate = DateTime.ParseExact(fechaNacString, "dd/MM/yyyy", null);
            Console.WriteLine("Calculando su edad...");
            Console.WriteLine(CalcularEdad(fechaNacDate) + " años");

            Console.Read();
        }

        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            return fechaActual.Subtract(fechaNacimiento).Days / 365;
        }
    }
}
