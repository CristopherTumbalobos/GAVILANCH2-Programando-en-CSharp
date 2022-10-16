using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio03
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 3: Escribir un método que acepte dos strings y devuelva el string con más caracteres. Si ambos tienen la misma cantidad de caracteres, devolver cualquiera de los dos.");
            Console.WriteLine("");

            Console.WriteLine("Escriba un string: ");
            string string1 = Console.ReadLine();
            Console.WriteLine("Escriba otro string: ");
            string string2 = Console.ReadLine();
            Console.WriteLine("Comparando strings...");
            CompararStrings(string1, string2);

            Console.Read();
        }

        static void CompararStrings(string cadena1, string cadena2)
        {
            if (cadena1.Length > cadena2.Length)
            {
                Console.WriteLine("El string más largo es: {0}", cadena1);
            }
            else if (cadena1.Length < cadena2.Length)
            {
                Console.WriteLine("El string más largo es: {0}", cadena2);
            }
            else if (cadena1.Length == cadena2.Length)
            {
                Console.WriteLine("Ambos tienen {0} caracteres", cadena1.Length);
            }
        }
    }
}
