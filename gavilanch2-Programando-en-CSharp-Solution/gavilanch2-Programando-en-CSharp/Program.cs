using System;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre = "Felipess";
            string nombreMayuscula = "FELIPESS";
            string frase = "Juan y Jose son amigos";

            var longitudNombre = nombre.Length;

            Console.WriteLine(longitudNombre);
            if (nombre.Length == 6)
            {
                Console.WriteLine(frase.Length);
            }
            else if (longitudNombre == 7)
            {
                Console.WriteLine("Longitud es 7");
            }
            else if (longitudNombre == 8)
            {
                Console.WriteLine("Longitud es 8");
                Console.WriteLine("Aqui estamos");
                Console.WriteLine("C# es cool");
                ComparaNombres(nombre, nombreMayuscula);

            }
            else
            {
                Console.WriteLine(nombre == nombreMayuscula);
            }


            Console.Read();
        }

        private static void ComparaNombres(string nombre, string nombreMayuscula)
        {
            if (nombre.ToUpper() == nombreMayuscula.ToUpper())
            {
                Console.WriteLine("Los nombres son iguales");
            }
        }
    }
}