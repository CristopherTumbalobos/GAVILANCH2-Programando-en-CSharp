using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio13
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 13: Escribir un método que acepte una lista con números y devuelva dicha lista en orden invertido.");
            Console.WriteLine("");

            while (true)
            {
                try
                {
                    Console.WriteLine("Cantidad de números de la lista: ");
                    int cantidad = int.Parse(Console.ReadLine());
                    List<int> listanumeros = new List<int>(cantidad);
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("Ingrese el número {0}: ", i + 1);
                        listanumeros.Add(int.Parse(Console.ReadLine()));
                    }
                    Console.WriteLine("Invirtiendo el orden de la lista...");
                    InvertirListaNumeros(listanumeros);
                    for (int i = 0; i < listanumeros.Count; i++)
                    {
                        Console.WriteLine(listanumeros[i]);
                    }
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

        static void InvertirListaNumeros(List<int> lista)
        {
            lista.Reverse();
        }
    }
}
