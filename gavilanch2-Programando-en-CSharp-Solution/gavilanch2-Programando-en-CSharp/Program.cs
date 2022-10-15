using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string estatusOperacion = "K15";

            if (estatusOperacion == EstatusOperaciones._exitoso)
            {
                // ...
            }
            else if (estatusOperacion == EstatusOperaciones._clienteNoEncontrado)
            {
                // ...
            }
            else if (estatusOperacion == EstatusOperaciones._errorDelSistema)
            {
                // ...
            }

            Console.Read();
        }
    }
}