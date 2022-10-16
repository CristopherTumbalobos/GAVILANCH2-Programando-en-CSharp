using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio05
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 5: Utilizando un iterador escribir en pantalla los números del 1 al 100 de dos en dos.");
            Console.WriteLine("");

            for (int i = 1; i < 100; i = i + 2)
            {
                Console.WriteLine("{0} y {1}", i, i + 1);
            }

            Console.Read();
        }
    }
}
