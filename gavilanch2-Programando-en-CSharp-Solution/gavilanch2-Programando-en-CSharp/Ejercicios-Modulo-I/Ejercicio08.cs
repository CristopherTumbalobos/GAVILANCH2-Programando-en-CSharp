using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio08
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 8: Escribir un método que acepte un int y te devuelva el factorial de dicho número.");
            Console.WriteLine("");

            while (true)
            {
                try
                {
                    Console.WriteLine("Escriba un número entero: ");
                    int numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Calculando factorial...");
                    Console.WriteLine(ObtenerFactorial(numero1));
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

        static int ObtenerFactorial(int numero)
        {
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
