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
        public static void ejemplo()
        {
            Animal perro = new Perro();
            Animal gato = new Gato();
            Animal pelicano = new Pelicano();
            Animal gusano = new Gusano();

            AnimalHacerRuido(perro);
            AnimalHacerRuido(gato);
            AnimalHacerRuido(pelicano);
            AnimalHacerRuido(gusano);
        }

        private static void AnimalHacerRuido(Animal animal)
        {
            animal.HacerRuido();
        }
    }

    class GoldenRetriever : Perro
    {

    }

    abstract class Animal
    //ABSTRACTA: No podemos instanciarla a sí misma, pero si podemos heredar de ella
    {
        public virtual void HacerRuido()
        {
            Console.WriteLine("Ruido Genérico");
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
        }
    }

    class Pelicano : Animal
    {
        public override void HacerRuido()
        {
            base.HacerRuido();
        }
    }

    sealed class Gusano : Animal
    {
        //SELLADA: No podemos heredar de ella, pero si podemos instanciarla
    }

    class Gusanito : Gusano
    {

    }
}