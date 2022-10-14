using System;
using System.Collections.Generic;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> nombres = new List<string>() { "felipe", "maria", "leonardo", "josefina" };

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        //break;
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //BREAK: Para salir del bucle
            //CONTINUE: Ignora todo el resto de código, y continua con el bucle

            int j = 0;
            while (true)
            {
                Console.WriteLine(j);
                j++;
                Console.WriteLine("Presione la tecla C si quiere cancelar");
                var respuestaUsuario = Console.ReadLine();
                if (respuestaUsuario.ToUpper() == "C")
                {
                    break;
                }
            }

            Console.Read();
        }
    }
}