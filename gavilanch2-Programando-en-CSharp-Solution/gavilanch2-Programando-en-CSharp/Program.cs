using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista que maneje ambos animales
            //Herencia: Ambas clases provienen de un mismo tipo
            List<Animal> animales = new List<Animal>();
            //Polimorfismo: Nos permite utilizar clases derivadas en lugar de la clase base
            animales.Add(new Vaca("Roberto"));
            animales.Add(new Oveja("Mario"));

            foreach (var animal in animales)
            {
                animal.HacerRuido();
            }

            Console.Read();
        }
    }

    class Animal
    {
        //Propiedad
        public string Nombre { get; set; }

        //virtual: Las clases hijos pueden sobrescribir el metodo virtual
        public virtual void HacerRuido()
        {
            Console.WriteLine("{0} hace ruido", Nombre);
        }
    }

    class Vaca : Animal
    {
        public Vaca(string nombre)
        {
            Nombre = nombre;
        }
        //override: Sobreescribir método "HacerRuido"
        public override void HacerRuido()
        {
            Console.WriteLine("{0} dice muuu", Nombre);
        }
        public void Limpiar()
        {
            Console.WriteLine("La vaca {0} ha sido limpiada", Nombre);
        }
    }
    class Oveja : Animal
    {
        public Oveja(string nombre)
        {
            Nombre = nombre;
        }
        //public void HacerRuido()
        //{
        //    Console.WriteLine("{0} dice veeeh", Nombre);
        //}
        public void Limpiar()
        {
            Console.WriteLine("La oveja {0} ha sido trasquilada", Nombre);
        }
    }
}