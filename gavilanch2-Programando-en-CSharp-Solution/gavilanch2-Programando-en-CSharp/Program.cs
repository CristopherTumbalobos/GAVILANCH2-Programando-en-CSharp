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

            AnimalHacerRuido(perro);
            AnimalHacerRuido(gato);
            AnimalHacerRuido(pelicano);
            AnimalHacerRuido(gusano);

            Console.Read();
        }

        public static void AnimalHacerRuido(Animal animal)
        {
            animal.HacerRuido();
        }
    }

    //PUBLIC: Usado por cualquiera que tuviese acceso a la clase que pertenece
    //PRIVATE: Usado solo por los miembros (propiedades, metodos, etc) del mismo tipo (struct o clase)
    //PROTECTED: Usado solo para los herederos o clases derivadas
    //INTERNAL: Usado solo para los que están en el mismo proyecto o assembly


    class Animal
    {
        public virtual void HacerRuido()
        {
            //Program.AnimalHacerRuido(this);
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
            base.HacerRuido();
        }
    }

    class Gusano : Animal
    {

    }
}