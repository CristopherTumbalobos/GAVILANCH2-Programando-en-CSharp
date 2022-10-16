using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio10
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 10: Escribir un método que acepte una lista de números y devuelva el número más grande.");
            Console.WriteLine("");

            Console.WriteLine("Cantidad de números de la lista: ");
            int cantidad = int.Parse(Console.ReadLine());
            List<int> listanumeros = new List<int>(cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el número {0}: ", i + 1);
                listanumeros.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Obteniendo el mayor número de la lista...");
            Console.WriteLine(ObtenerMayorDeLaLista(listanumeros));

            Console.Read();
        }

        static int ObtenerMayorDeLaLista(List<int> listanumeros)
        {
            int numeroMayor = -99999;
            foreach (int numero in listanumeros)
            {
                if (numero > numeroMayor)
                {
                    numeroMayor = numero;
                }
            }

            return numeroMayor;
        }
    }
}
