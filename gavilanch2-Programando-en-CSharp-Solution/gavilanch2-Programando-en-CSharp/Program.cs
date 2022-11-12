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
            var persona = new Persona() { Nombre = "Felipe" };

            //Tipo de referencia
            Console.WriteLine("--Tipo de referencia--");
            Console.WriteLine("Previo al cambio");
            Console.WriteLine(persona.Nombre);
            EditarPersona(persona, "Roberto");
            Console.WriteLine("Despues del cambio");
            Console.WriteLine(persona.Nombre);

            Console.WriteLine("");

            //Tipo de valor
            //Almacena directamente el valor
            Console.WriteLine("--Tipo de valor--");
            Console.WriteLine("Previo al cambio");
            int edad = 9;
            Console.WriteLine(edad);
            //ref: Permite pasar un valor como una referencia
            EditarEdad(ref edad, 14);
            //EditarEdad(out edad, 14);
            //OUT: Obliga asignarle un valor a las variables marcadas con out
            //REF: No obliga declararle un valor a la variables marcadas con ref
            //EditarEdad(out edad, 14);
            Console.WriteLine("Despues del cambio");
            Console.WriteLine(edad);

            Console.Read();
        }

        static void EditarPersona(Persona persona, string nuevoNombre)
        {
            persona.Nombre = nuevoNombre;
        }

        static void EditarEdad(ref int edadActual, int nuevaEdad)
        {
            edadActual = nuevaEdad;
        }

        //static void EditarEdad(out int edadActual, int nuevaEdad)
        //{
        //    edadActual = nuevaEdad;
        //}
    }

    class Persona
    {
        public string Nombre { get; set; }
    }
}