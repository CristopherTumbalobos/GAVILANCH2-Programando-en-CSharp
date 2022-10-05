using System;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Nombre = "Felipe";
            //VAR: Infiere el tipo de la variable a partir del valor
            var Nombre = "Felipe";
            var mes = 5;
            var procesoTerminado = false;

            string direccion;
            //var nuevaDireccion; (ERROR: No tiene un valor del cual se puede inferir su tipo)
            //Instanciando la clase "Persona"
            var p = new Persona();
            p.Nombre = "Felipe";

            Console.Read();
        }

        class Persona
        {
            public string Nombre;
            public int Edad;
            public string Direccion;

            public void MostrarDatosEnConsola()
            {
                string output = "El nombre es {0}, la edad es {1} y su dirección es {2}";
                output = string.Format(output, Nombre, Edad, Direccion);
                Console.WriteLine(output);
            }
        }
    }
}
