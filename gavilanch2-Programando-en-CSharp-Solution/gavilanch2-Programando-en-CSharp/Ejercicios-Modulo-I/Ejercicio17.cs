using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio17
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 17: Escribir un método que acepte una lista de strings y escriba en la consola el último caracter de cada uno de los strings.");
            Console.WriteLine("");

            Console.WriteLine("Cantidad de strings de la lista: ");
            int cantidad = int.Parse(Console.ReadLine());
            List<string> listastrings = new List<string>(cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese el string {0}: ", i + 1);
                listastrings.Add(Console.ReadLine());
            }
            Console.WriteLine("Obteniendo el ultimo caracter de cada string...");
            UltimoCaracterString(listastrings);

            Console.Read();
        }

        static void UltimoCaracterString(List<string> lista)
        {
            foreach (string elemento in lista)
            {
                Console.WriteLine(elemento.Substring(elemento.Length - 1, 1));
            }
        }
    }
}
