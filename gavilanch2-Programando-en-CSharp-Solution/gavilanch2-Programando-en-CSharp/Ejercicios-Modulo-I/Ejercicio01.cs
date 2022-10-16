using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio01
    {
        public static void Desarrollo ()
        {
            Console.WriteLine("EJERCICIO 1: Permitir al usuario escribir dos números y mostrar en pantalla cuál de los dos es el más grande.Si son iguales, mostrar cualquiera.");
            Console.WriteLine("");

            while (true)
            {
                try
                {
                    Console.WriteLine("Escriba un número: ");
                    //int.Parse: Para convertir de string a int
                    int numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba otro número: ");
                    int numero2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("El número más grande es: ");
                    if (numero1 > numero2)
                    {
                        Console.WriteLine(numero1);
                    }
                    else
                    {
                        Console.WriteLine(numero2);
                    }
                    //Si llegamos hasta aqui es porque todo esta bien
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Asegurese de escribir valores numéricos");
                }
            }

            Console.Read();
        }
    }
}
