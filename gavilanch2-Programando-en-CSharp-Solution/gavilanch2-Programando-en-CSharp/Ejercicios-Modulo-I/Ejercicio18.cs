using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio18
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 18: Escribir un método que acepte un string y devuelva true si dicho string es un palíndromo, si no lo es devuelve false. Un palíndromo es un texto que es igual al derecho y al revés. Ejemplos: ana es un palíndromo, pero Pirata no es palíndromo.");
            Console.WriteLine("");

            Console.WriteLine("Escriba una palabra: ");
            string palabra = Console.ReadLine();
            Console.WriteLine("Verificando si es un palindromo...");
            VerificarPalindromo(palabra);

            Console.Read();
        }

        static void VerificarPalindromo(string palabra)
        {
            // 0 = TRUE
            // 1 = FALSE
            int llave = 0;
            if (palabra.Length % 2 == 0)
            {
                for (int i = 0; i < palabra.Length / 2; i++)
                {
                    for (int j = palabra.Length - 1; j >= palabra.Length / 2; j--)
                    {
                        if (i + j == palabra.Length - 1)
                        {
                            if (palabra[i] != palabra[j])
                            {
                                llave = 1;
                            }
                        }
                    }
                }
            }

            else
            {
                for (int i = 0; i < (palabra.Length - 1) / 2; i++)
                {
                    for (int j = palabra.Length - 1; j >= (palabra.Length + 1) / 2; j--)
                    {
                        if (i + j == palabra.Length - 1)
                        {
                            if (palabra[i] != palabra[j])
                            {
                                llave = 1;
                            }
                        }
                    }
                }
            }

            if (llave == 0)
            {
                Console.WriteLine("{0}: SI es un palindromo", palabra);
            }
            else if (llave == 1)
            {
                Console.WriteLine("{0}: NO es un palindromo", palabra);
            }
        }
    }
}
