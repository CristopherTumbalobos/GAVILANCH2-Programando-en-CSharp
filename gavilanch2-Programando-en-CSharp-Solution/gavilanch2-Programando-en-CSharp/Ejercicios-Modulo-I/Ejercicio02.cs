using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio02
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 2: Escribir un método que acepte un número y devuelva True si el número es par, o false si es impar.");
            Console.WriteLine("");

            while (true)
            {
                try
                {
                    Console.WriteLine("Escriba un número: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Verificando Paridad...");
                    VerificarParidad(numero);
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

        static void VerificarParidad(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
        }
    }
}
