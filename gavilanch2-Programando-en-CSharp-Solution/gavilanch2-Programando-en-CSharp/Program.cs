using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Vector();
            var v2 = new Vector(new List<int> { 1, 2 });
        }
    }

    class Vector
    {
        //Constructor: Para instanciar una clase
        //Constructor: Primer método que se ejecuta
        //Constructor: Tiene el mismo nombre que la clase
        //CONTRUCTOR 1
        public Vector()
        {
            //...
        }

        //CAMPO
        private List<int> _Valores;

        //CONSTRUCTOR 2
        public Vector(List<int> valores)
        {
            _Valores = valores;
        }
    }
}