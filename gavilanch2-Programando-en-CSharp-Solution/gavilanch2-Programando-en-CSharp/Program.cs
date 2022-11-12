using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        const double PI = 3.14; //Necesita tener el valor en su declaracion
        static readonly double PI_2 = RepositorioDeValores.PI; // RECOMENDADO: Lo puede leer de un repositorio

        static void Main(string[] args)
        {
            var edad = 9;
            edad = 8;
            edad = 125;

            Console.Read();
        }
    }

    public static class RepositorioDeValores
    {
        public static double PI = 3.1415;
    }
}