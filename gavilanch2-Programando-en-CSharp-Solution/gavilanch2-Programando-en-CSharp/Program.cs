using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var iteradordeLista = new IteradorDeLista();
            iteradordeLista.Lista = new List<int>() { 1, 2, 3 };
            iteradordeLista.EscribirLista();

            iteradordeLista.Lista = null;
            iteradordeLista.EscribirLista();

            Console.Read();
        }
    }

    class IteradorDeLista
    {
        //Constructor que inicializa un campo
        public IteradorDeLista()
        {
            _lista = new List<int>();
        }

        //Campo privado
        private List<int> _lista;

        //Encapsulamiento
        //Permite manejar la recuperacion y escritura de variables o campos privados
        //Propiedad: Nos permite encapsular nuestros campos
        public List<int> Lista
        {
            get
            { return _lista; }
            set
            {
                if (value != null)
                {
                    _lista = value;
                }
                else
                {
                    Lista = new List<int>();
                }
            }
        }

        public void EscribirLista()
        {
            foreach (var item in _lista)
            {
                Console.WriteLine(item);
            }
        }

        public void EscribirLista2()
        {
            foreach (var item in _lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}