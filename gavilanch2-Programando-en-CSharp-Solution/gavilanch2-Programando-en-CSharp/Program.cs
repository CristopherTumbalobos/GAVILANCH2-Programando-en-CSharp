using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBJETO 1
            var e1 = new Empresa();
            e1._NombreLegal = "Primera Empresa";
            e1._Direccion = "Primera Direccion";

            //OBJETO 2
            var e2 = new Empresa();
            e2._NombreLegal = "Segunda Empresa";
            e2._Direccion = "Segunda Direccion";

            //Contexto.metodo1(Objeto);
            e1.metodo1(e2);
            e2.metodo1(e1);
            e1.metodo1(e1);

            Console.Read();
        }

        class Empresa
        {
            //Campos
            public string _NombreLegal;
            public string _Direccion;

            //Metodo
            public void metodo1(Empresa empresa2)
            {
                //this: Sirve para indicar que estamos trabajando con miembros de la clase en el contexto que estamos.
                var this_nombreLegal = this._NombreLegal;
                var this_direccion = this._Direccion;
                var miNombreLegal = _NombreLegal;//Igual a this._NombreLegal
                var miDireccion = _Direccion;//Igual a this._Direccion
                var empresa2_nombreLegal = empresa2._NombreLegal;
                var empresa2_direccion = empresa2._Direccion;
            }
        }
    }
}