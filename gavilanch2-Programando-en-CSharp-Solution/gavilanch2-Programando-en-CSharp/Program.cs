using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector(new List<int> { 3, 4, 8 });
            var v2 = new Vector(new List<int> { 1, 2 });
            Vector vectorSuma = v1.Suma(v2);
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

        //INDEXADOR
        public int this[int i]
        {
            get { return _componentes[i]; }
            set { _componentes[i] = value; }
        }

        public int Dimension { get { return _componentes.Count; } }

        public string Nombre { get; private set; }

        //CONSTRUCTOR
        public Vector(List<int> componentes)
        {
            _componentes = componentes;
        }

        //METODO: Bloque de código que podemos ejecutar varias veces
        public Vector Suma(Vector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("Las dimensiones no son iguales");
            }

            List<int> resultado = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                //this: Para hacer referencia a la clase en la que te encuentras
                //this[i]: Utiliza el indexador para traer el enesimo elemento
                resultado.Add(this[i] + v2[i]);
            }

            return new Vector(resultado);
        }
    }
}