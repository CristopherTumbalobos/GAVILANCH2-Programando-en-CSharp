using System;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PreguntaNombreYEdad();
            Console.Read();
        }

        /// <summary>
        /// Hacer un programa que le pregunte al usuario su nombre y edad, posterior a eso debe mostrar un mensaje en pantalla con el nombre del usuario y su edad.
        /// Pista: Utilice Console.ReadLine para leer la información que ingresa el usuario
        /// Pista 2: Utilice int.Parse para convertir de tipo string a tipo int
        /// </summary>
        /// <param name="args"></param>
        static void PreguntaNombreYEdad()
        {
            string nombre;
            int edad;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            //FORMAT: Nos permite insertar valores en un string de una manera sencilla
            string output = string.Format("Su nombre es {0} y tiene {1} años de edad", nombre, edad);
            Console.WriteLine(output);
        }
    }
}
