using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio09
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 9: Escribir un método que acepte una lista de números y devuelva su promedio.");
            Console.WriteLine("");

            while (true)
            {
                try
                {
                    Console.WriteLine("Cantidad de números de la lista: ");
                    int cantidad1 = int.Parse(Console.ReadLine());
                    List<int> listanumeros = new List<int>(cantidad1);
                    for (int i = 0; i < cantidad1; i++)
                    {
                        Console.WriteLine("Ingrese el número {0}: ", i + 1);
                        listanumeros.Add(int.Parse(Console.ReadLine()));
                    }
                    Console.WriteLine("Promediando los numeros de la lista...");
                    Console.WriteLine(PromediarNumerosDeLista(listanumeros, cantidad1));
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

        static double PromediarNumerosDeLista(List<int> listanumeros, int cantidad)
        {
            double suma = 0;

            foreach (int numero in listanumeros)
            {
                suma += numero;
            }

            return suma / cantidad;
        }
    }
}
