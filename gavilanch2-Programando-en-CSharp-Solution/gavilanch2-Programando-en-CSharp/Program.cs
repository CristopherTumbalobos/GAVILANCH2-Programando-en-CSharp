using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        //LIFO: Similar al lavar platos
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            Console.Write("Primer elemento insertado: ");
            Console.WriteLine("A");
            stack.Push("A");

            Console.Write("Segundo elemento insertado: ");
            Console.WriteLine("B");
            stack.Push("B");

            Console.Write("Tercer elemento insertado: ");
            Console.WriteLine("C");
            stack.Push("C");

            //Push: Insertar elemento al STACK
            //Pop: Extraer elemento del STACK

            Console.Write("Primer elemento extraido: ");
            var primerElementoRemovido = stack.Pop();
            Console.WriteLine(primerElementoRemovido);

            Console.Write("Segundo elemento extraido: ");
            Console.WriteLine(stack.Pop());

            Console.Write("Tercer elemento extraido: ");
            Console.WriteLine(stack.Pop());

            Console.WriteLine();
            Console.Read();
        }
    }
}