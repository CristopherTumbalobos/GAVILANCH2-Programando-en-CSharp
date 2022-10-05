using System;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        //BLOQUE: El interior entre dos llaves {}
        static void Main(string[] args)
        {
            EscribeHolaMundo();
            EscribeEnLaConsola("Me llamo Felipe");
            IdentificadorDelMetodo("valor1", "valor2", 6);
            int sumando1 = 5;
            int sumando2 = 7;
            int resultado = Suma(sumando1, sumando2);
            Console.WriteLine(resultado);
            Console.Read();
        }

        static int Suma(int a, int b)
        {
            return a + b;
        }

        static void EscribeHolaMundo()
        {
            Console.WriteLine("Hola mundo");
        }

        static void EscribeEnLaConsola(string valor)
        {
            Console.WriteLine(valor);
        }

        //Sintaxis de un metodo static void
        static void IdentificadorDelMetodo(string parametro1, string parametro2, int etc)
        {

        }
    }
}
