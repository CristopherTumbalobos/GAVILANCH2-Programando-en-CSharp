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
        //FIFO: Similar a la FILA de un banco
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            Console.Write("Primer elemento insertado: ");
            Console.WriteLine("Primero");
            queue.Enqueue("Primero");

            Console.Write("Segundo elemento insertado: ");
            Console.WriteLine("Segundo");
            queue.Enqueue("Segundo");

            Console.Write("Tercer elemento insertado: ");
            Console.WriteLine("Tercero");
            queue.Enqueue("Tercero");

            //Podemos iterar el queue para leer su contenido
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.Write("Primer elemento extraído: ");
            var primerElementoRemovido = queue.Dequeue();
            Console.WriteLine(primerElementoRemovido);

            Console.Write("Segundo elemento extraído: ");
            Console.WriteLine(queue.Dequeue());

            Console.Write("Tercer elemento extraído: ");
            Console.WriteLine(queue.Dequeue());

            //El queue esta vacio en este momento

            Console.Read();
        }
    }
}