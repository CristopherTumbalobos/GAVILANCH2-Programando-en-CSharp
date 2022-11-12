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
        //Genéricos: Los genéricos nos sirven para parametrizar uno o varios tipos que usaremos dentro de un método, clase, interfaz, etc.
        static void Main(string[] args)
        {
            //Lista de tipo de valor
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };
            numeros.Add(6);

            //Lista de tipo de referencia
            List<Persona> personas = new List<Persona>()
            {
                new Persona () {Nombre = "Felipe"},
                new Persona () {Nombre = "Carla"}
            };
        }

        private int Duplicar(int valor)
        {
            return valor * 2;
        }

        private double Duplicar(double valor)
        {
            return valor * 2;
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
    }

    class Empresa
    {
        public string Direccion { get; set; }
    }
}