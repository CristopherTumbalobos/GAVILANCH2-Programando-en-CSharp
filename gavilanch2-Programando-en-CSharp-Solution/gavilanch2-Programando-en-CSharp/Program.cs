using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    //Abstract: Aquella que no podemos instanciar
    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro();
            Animal gato = new Gato();
            Animal pelicano = new Pelicano();
            Animal gusano = new Gusano();

            Animal animal = new Animal();

            AnimalHacerRuido(perro);
            AnimalHacerRuido(gato);
            AnimalHacerRuido(pelicano);
            AnimalHacerRuido(gusano);

            Console.Read();
        }

        private static void AnimalHacerRuido(Animal animal)
        {
            animal.HacerRuido();
        }
    }

    abstract class Animal
    {
        public virtual void HacerRuido()
        {
            Console.WriteLine("Ruido Generico");
        }
        protected void MetodoProtegido()
        {

        }
    }

    class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Woof");
            MetodoProtegido();
        }
        public void ElBaile()
        {
            Console.WriteLine("Del Perrito");
        }
    }

    class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miau");
            MetodoProtegido();
        }
    }

    class Pelicano : Animal
    {
        public override void HacerRuido()
        {
            base.HacerRuido();
        }
    }

    class Gusano : Animal
    {

    }
}