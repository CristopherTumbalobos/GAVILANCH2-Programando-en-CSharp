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
        static void Main(string[] args)
        {
            MiColeccion<decimal, string> miColeccion = new MiColeccion<decimal, string>();
            miColeccion.Agregar(20);
            miColeccion.Agregar("Felipe");

            Console.Read();
        }
    }

    class MiColeccion<T, M>
    {
        public List<T> MiLista { get; set; }

        public MiColeccion()
        {
            MiLista = new List<T>();
        }
        public void Agregar(T valor)
        {
            MiLista.Add(valor);
        }
        public void Agregar(M valor)
        {
            //...
        }
    }
}