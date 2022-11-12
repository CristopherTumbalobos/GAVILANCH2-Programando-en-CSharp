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
            var miDobleColeccion = FactoriaMiDobleColeccion<string, int>(1);
            miDobleColeccion.Agregar("Felipe", 7);

            Console.Read();
        }

        //Factoria: Metodo que devuelve un clase que implemente el interfaz
        static IMiDobleColeccion<T, M> FactoriaMiDobleColeccion<T, M>(int discriminante)
        {
            if (discriminante == 1)
            {
                return new MiDobleColeccion<T, M>();
            }
            else if (discriminante == 2)
            {
                return new MiDobleColeccionDiccionario<T, M>();
            }
            throw new NotImplementedException();
        }
    }

    //Interfaz genérica
    interface IMiDobleColeccion<T, M>
    {
        void Agregar(T valorT, M valorM);
    }

    class MiDobleColeccion<T, M> : IMiDobleColeccion<T, M>
    {
        public List<T> MiListadeT { get; set; }
        public List<M> MiListadeM { get; set; }

        //public void Agregar(T valorT, M valorM)
        //{
        //    throw new NotImplementedException();
        //}

        public MiDobleColeccion()
        {
            MiListadeT = new List<T>();
            MiListadeM = new List<M>();
        }

        public void Agregar(T valorT, M valorM)
        {
            MiListadeT.Add(valorT);
            MiListadeM.Add(valorM);
        }
    }

    class MiDobleColeccionDiccionario<T, M> : IMiDobleColeccion<T, M>
    {
        public Dictionary<T, M> MiDictionary { get; set; }
        public void Agregar(T valorT, M valorM)
        {
            //
        }
    }
}