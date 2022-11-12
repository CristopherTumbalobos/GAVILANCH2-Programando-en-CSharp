using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos anonimos
            var animalito1 = new { animal = "perro", nombre = "Roberto", vidas = 1 };
            var animalito2 = new { animal = "gato", nombre = "Alex", vidas = 7 };

            //Dynamic: Permite crear un lista de anonimos. Es lento comparado a otras estructuras. Por lo general, evitar su uso.
            List<dynamic> animalitos = new List<dynamic>();

            animalitos.Add(animalito1);
            animalitos.Add(animalito2);

            foreach (dynamic animalito in animalitos)
            {
                Console.WriteLine("El {0} de nombre {1} tiene {2} vidas", animalito.animal, animalito.nombre, animalito.vidas);
            }

            Console.Read();
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}