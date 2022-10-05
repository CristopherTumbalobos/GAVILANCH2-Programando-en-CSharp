using System;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        //ALCANCE: Desde donde podemos acceder a una variable (atributo) o metodo, o instanciar una clase
        //BLOQUE: Interior entre dos llaves {}
        static void Main(string[] args)
        {

            string nombre = "Felipe";

            nombre = "Juan";
            edad = 45; //Si se puede asignar valor a "edad" porque la variable "edad" es static

            var p = new Persona();
            p.PaisOrigen = "Republica Dominicana";
            //p.edad2 = 45; (ERROR: "edad2" es un atributo privado)
            p.obtenerEdad();

            Console.Read();
        }

        public void Main2()
        {
            //nombre = "Pedro"; (ERROR: "nombre" no esta definida dentro del mismo bloque)
        }

        //nombre = "Pedro"; (ERROR: "nombre" no esta definida dentro del mismo bloque)
        static int edad = 21;

        class Persona
        {
            public string PaisOrigen;
            private int edad2;

            public int obtenerEdad()
            {
                return edad2;
            }
        }
    }
}
