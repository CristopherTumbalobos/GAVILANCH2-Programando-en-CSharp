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
            List<string> nombres = new List<string>();
            nombres.Add("Felipe");
            nombres.Add("Mario");
            nombres.Add("Carlos");

            //Inicializando lista con algunos elementos
            List<int> numeros = new List<int>() { 1, 5, 7, 8, -3, 6, 2, 4, 6 };
            numeros.Add(0);

            //Remover elemento
            numeros.Remove(8);
            //Remover el numero asociado a un index (indice)
            numeros.RemoveAt(2);

            //Remover el último elemento
            numeros.RemoveAt(numeros.Count - 1);

            //Insertar elemento a un index determinado
            numeros.Insert(0, 100);
            numeros.Insert(4, -100);

            var primerElementoDeLaLista = numeros[0];
            var ultimoElementoDeLaLista = numeros[numeros.Count - 1];
            //numeros.Clear();
            Console.Read();
        }
    }
}