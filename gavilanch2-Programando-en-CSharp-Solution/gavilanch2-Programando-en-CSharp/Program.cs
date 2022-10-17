using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var v2 = new Vector(new List<int> { 1, 2 });
            Console.WriteLine(v2.Componentes.ToString());
            Console.WriteLine(v2.Dimension);
            v2[0] = 5;
            Console.WriteLine("Indexador");
            Console.WriteLine(v2[0]);
            Console.WriteLine(v2.Componentes[1]);
            Console.Read();
        }
    }

    class Vector
    {
        //CAMPO
        private List<int> _componentes;

        //PROPIEDADES
        public List<int> Componentes
        {
            get
            {
                return _componentes;
            }
        }

        //INDEXADOR: Propiedad especial
        public int this[int i]
        {
            get { return _componentes[i]; }
            set { _componentes[i] = value; }
        }
        //value: Representa el valor que le estamos asignando a una propiedad

        public int Dimension { get { return _componentes.Count; } }

        public string Nombre { get; private set; }

        
        //CONSTRUCTOR
        public Vector(List<int> componentes)
        {
            _componentes = componentes;
            Nombre = "Vector 1";
        }
    }
}