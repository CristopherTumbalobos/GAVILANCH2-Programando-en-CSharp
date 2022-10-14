using System;
using System.Collections.Generic;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> nombres = new List<string>() { "felipe", "maria", "leonardo", "josefina" };

            //for (int i = 0; i < nombres.Count; i++)
            //{
            //    nombres[i] = nombres[i] + "s";
            //    Console.WriteLine(nombres[i]);
            //}

            //FOREACH: No puede editar los elementos de la lista que estas iterando, en cambio FOR si puede
            foreach (string nombre in nombres)
            {
                nombre = nombre + "s";
                Console.WriteLine(nombre.ToUpper());
            }

            Console.Read();
        }
    }
}