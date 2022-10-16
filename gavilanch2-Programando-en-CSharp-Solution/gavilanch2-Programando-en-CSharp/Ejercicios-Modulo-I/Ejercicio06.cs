using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio06
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 6: Escribir un método que acepte un double que represente un número en grados Celcius y lo transforme a grados Fahrenheit.");
            Console.WriteLine("");

            while (true)
            {
                try
                {
                    Console.WriteLine("Escriba una temperatura en Celcius: ");
                    double temperatura1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Convirtiendo a Farenheit...");
                    Console.WriteLine(CelciusAFahrenheit(temperatura1));
                    Console.Read();
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Asegurese de escribir valores numéricos");
                }
            }

            Console.Read();
        }

        static double CelciusAFahrenheit(double temperatura)
        {
            return 9.0 / 5 * (temperatura) + 32;
        }
    }
}
