using System;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 8;
            var d = 9;

            Console.WriteLine("Operaciones Logicas");

            var booleano = true;
            Console.WriteLine("Operacion negacion: !{0} = {1}", booleano, !booleano);
            Console.WriteLine("");

            Console.WriteLine("Conjuncion");
            Console.WriteLine("{0} & {0} = {1}", true, true & true);
            Console.WriteLine("{0} & {0} = {1}", false, false & false);
            Console.WriteLine("{0} & {1} = {2}", true, false, true & false);

            //&&: El segundo operando solo se evalua si el primero es true

            Console.WriteLine("");

            Console.WriteLine("Disyuncion exclusiva");
            Console.WriteLine("{0} ^ {0} = {1}", true, true ^ true);
            Console.WriteLine("{0} ^ {0} = {1}", false, false ^ false);
            Console.WriteLine("{0} ^ {1} = {2}", true, false, true ^ false);

            Console.WriteLine("");

            Console.WriteLine("Disyunción Inclusiva");
            Console.WriteLine("{0} | {0} = {1}", true, true | true);
            Console.WriteLine("{0} | {1} = {2}", true, false, true | false);
            Console.WriteLine("{0} | {1} = {2}", false, false, false | false);

            Console.Read();
        }
    }
}
