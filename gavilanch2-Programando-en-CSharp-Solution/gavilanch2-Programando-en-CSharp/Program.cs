using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            metodo1("valor1");
            metodo1("valor1", "valor2");
            Console.WriteLine("");
            metodo1("Felipe", "Mario");
            Console.Read();
        }

        private static void metodo1(string v1)
        {
            metodo1(v1, "valor2");
        }

        //Los valores pueden ser peligrosos, si lo tienes en otra libreria (assembly o dll), para que el cambio funcione todos los proyectos deberan ser recompilados. 

        private static void metodo1(string v1, string v2 = "valor2")
        {
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
    }
}