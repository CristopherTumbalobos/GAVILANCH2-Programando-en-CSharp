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
            Console.WriteLine(v2.Nombre);
            Console.Read();
        }
    }

    class Vector
    {
        //CAMPO: Variable declarada a nivel de clase
        private List<int> _componentes;

        //PROPIEDADES: Método especial que devuelve y asigna un valor
        //GET: Obtener un valor
        //SET: Asignar un valor
        public List<int> Componentes
        {
            get
            {
                return _componentes;
            }
        }

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