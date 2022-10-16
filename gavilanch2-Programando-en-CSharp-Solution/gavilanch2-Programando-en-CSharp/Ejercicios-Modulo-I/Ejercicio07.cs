using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio07
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 7: Escribir un método que acepte una lista de números y devuelva el producto de dichos números.");
            Console.WriteLine("");

            Console.WriteLine("Cantidad de números de la lista: ");
            int cantidad = int.Parse(Console.ReadLine());
            List<int> listanumeros = new List<int>(cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el número {0}: ", i + 1);
                listanumeros.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Multiplicando los numeros de la lista...");
            Console.WriteLine(MultiplicarNumerosDeLista(listanumeros));

            Console.Read();
        }

        static int MultiplicarNumerosDeLista(List<int> listanumeros)
        {
            int producto = 1;

            foreach (int numero in listanumeros)
            {
                producto *= numero;
            }

            return producto;
        }
    }
}
