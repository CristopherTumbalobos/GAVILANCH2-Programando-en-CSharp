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
            //Dos elementos del diccionario no pueden tener la misma llave (llave - valor)
            Dictionary<string, int> NombreEdad = new Dictionary<string, int>();
            NombreEdad.Add("Felipe", 85);
            NombreEdad.Add("Roberto", 40);
            NombreEdad.Add("Maria", 40);

            Console.WriteLine(NombreEdad["Roberto"]);

            //Consulta si existe la llave "blablabla"
            if (NombreEdad.ContainsKey("blablabla"))
            {
                Console.WriteLine(NombreEdad["blablabla"]);
            }

            //Remover elemento de un diccionario
            NombreEdad.Remove("Roberto");

            //Dictionary<int, Persona> personas = new Dictionary<int, Persona>();
            //personas.Add(1, );

            foreach (var keys in NombreEdad.Keys)
            {
                Console.WriteLine(keys);
            }


            Console.Read();
        }
    }

    class Persona
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
    }
}