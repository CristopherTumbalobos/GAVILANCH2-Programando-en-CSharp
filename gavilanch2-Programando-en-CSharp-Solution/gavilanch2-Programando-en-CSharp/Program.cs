﻿using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var v1 = new Vector(new List<int> { 3, 4, 5 });
            var v2 = new Vector(new List<int> { 1, 2, -9 });
            Vector vectorSuma = v1.Suma(v2);
            Vector vectorSuma2 = v1 + v2;
            v1++;
            Console.Read();

        }
    }

    //CLASS: Tipo de referencia que podemos definir
    //STRUCT: Tipo de valor que podemos definir, la usamos cuando nuestras instancias tengan un corto tiempo de vida, tiene poca data, problemas de performace cuando se castea muchas veces, se manejan mejor un arreglo de tipo de valor que de tipo de referencia.


    struct Vector
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

        //METODO 2
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return vector1.Suma(vector2);
        }

        public static int operator *(Vector vector1, Vector vector2)
        {
            throw new NotImplementedException();
        }

        public static Vector operator ++(Vector vector1)
        {
            throw new NotImplementedException();
        }

        //METODO 1
        public Vector Suma(Vector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("Las dimensiones no son iguales");
            }

            List<int> resultado = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                resultado.Add(this[i] + v2[i]);
            }

            return new Vector(resultado);
        }
    }
}