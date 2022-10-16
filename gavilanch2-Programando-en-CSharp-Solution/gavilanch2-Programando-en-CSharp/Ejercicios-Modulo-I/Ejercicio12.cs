using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio12
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 12: Escribir un fizzbuzz: Iterar los números del uno al cien, y cuando llegues a un número que sea múltiplo de 3(el 6 por ejemplo), escribir en la consola Fizz, cuando llegues a un número que sea múltiplo de 5(el 20 por ejemplo) escribir en la consola Buzz, cuando llegues a un número que sea múltiplo de 3 y 5(el 30 por ejemplo) escribir FizzBuzz en la consola.");
            Console.WriteLine("");

            Console.WriteLine("FIZZBUZZ");
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("{0} --- FizzBuzz", i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("{0} --- Buzz", i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("{0} --- Fizz", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.Read();
        }
    }
}
