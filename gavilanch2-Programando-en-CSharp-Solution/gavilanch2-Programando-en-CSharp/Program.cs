using System;
using System.Collections.Generic;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
            }

            List<string> nombres = new List<string>() { "felipe", "maria", "leonardo", "josefina" };

            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i].ToUpper());
            }

            Console.Read();
        }
    }
}