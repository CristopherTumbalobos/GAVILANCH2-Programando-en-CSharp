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
        //Podemos aplicar una o varias restricciones a un genérico, separandolas por coma
        static void Main(string[] args)
        {
            Generico_struct<int>(5);
            Generico_class<Perro>();
            Generico_Herencias<Gato>(new Gato());
        }

        static void Generico_struct<T>(T valor) where T : struct
        {

        }
        static M Generico_class<M>() where M : class, new()
        {
            return new M();
        }
        static void Generico_interface<T>(T implementacion) where T : IEnumerable<T>
        {
            foreach (T item in implementacion)
            {

            }
        }
        static C Generico_Constructor<C>() where C : new()
        {
            return new C();
        }
        static void Generico_Herencias<A>(A animal) where A : Animal
        {
            animal.HacerRuido();
        }
    }

    abstract class Animal
    {
        public abstract void HacerRuido();
    }
    class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Woof");
        }
    }
    class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miau");
        }
    }
}