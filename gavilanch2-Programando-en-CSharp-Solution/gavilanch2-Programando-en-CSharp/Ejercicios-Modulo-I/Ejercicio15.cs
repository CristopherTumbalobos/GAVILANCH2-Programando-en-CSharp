using System;
using System.Collections.Generic;
using System.Text;

namespace gavilanch2_Programando_en_CSharp.Ejercicios_Modulo_I
{
    public class Ejercicio15
    {
        public static void Desarrollo()
        {
            Console.WriteLine("EJERCICIO 15: Escribir un método que acepte una lista de números y devuelva una lista con los mismos números ordenados de mayor a menor.");
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
                    Console.WriteLine("Ordenando la lista de mayor a menor...");
                    OrdenarMayorAMenor(listanumeros, cantidad);
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

        static void OrdenarMayorAMenor(List<int> lista, int cantidad)
        {
            int aux = 0;
            for (int j = 1; j < cantidad; j++)
            {
                for (int k = 0; k < cantidad - 1; k++)
                {
                    if (lista[k] < lista[j])
                    {
                        aux = lista[k];
                        lista[k] = lista[j];
                        lista[j] = aux;
                    }
                }
            }
            for (int g = 0; g < cantidad; g++)
            {
                if (g != cantidad - 1)
                {
                    Console.Write(lista[g] + " - ");
                }
                else
                {
                    Console.WriteLine(lista[g]);
                }
            }
        }
    }
}
