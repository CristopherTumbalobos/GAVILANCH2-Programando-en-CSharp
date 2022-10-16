using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio04
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 4: Escribir un método que acepte dos catetos y devuelve la hipotenusa (usar la clase Math para calcular la raíz cuadrada).");
            Console.WriteLine("");

            while (true)
            {
                try
                {
                    Console.WriteLine("Escriba un número: ");
                    int numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba otro número: ");
                    int numero2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Calculando Hipotenusa...");
                    Console.WriteLine(ObtenerHipotenusa(numero1, numero2));
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

        static double ObtenerHipotenusa(int cateto1, int cateto2)
        {
            return Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
        }
    }
}
