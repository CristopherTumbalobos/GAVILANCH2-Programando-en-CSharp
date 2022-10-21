using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object: Todos los tipos de C# heredan de objeto
            Object o = DateTime.Today;

            if (o is DateTime)
            {
                //Casteando el objeto "o"
                var fecha = (DateTime)o;
            }
            else if (o is string)
            {
                //Casteando el objeto "o"
                var unString = (string)o;
            }

            Console.Read();
        }

        public static void ToStringObject(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}