using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro();
            Animal gato = new Gato();
            Animal pelicano = new Pelicano();
            Animal gusano = new Gusano();

            //Polimorfismo por Herencia
            AnimalHacerRuido(perro);
            AnimalHacerRuido(gato);
            AnimalHacerRuido(pelicano);
            AnimalHacerRuido(gusano);

            Console.Read();
        }

        //Metodo que recibe una clase base y podemos pasarle clases derivadas
        public static void AnimalHacerRuido(Animal animal)
        {
            animal.HacerRuido();
        }
    }

    class Animal
    {
        public virtual void HacerRuido()
        {
            Console.WriteLine("Ruido Genérico");
        }
    }

    class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Woof");
        }
        public void ElBaile()
        {
            Console.WriteLine("Del perrito");
        }
    }

    class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miau");
        }
    }

    class Pelicano : Animal
    {
        public override void HacerRuido()
        {
            //base: Utilizar el método base, de la clase padre
            base.HacerRuido();
        }
    }

    class Gusano : Animal
    {

    }
}