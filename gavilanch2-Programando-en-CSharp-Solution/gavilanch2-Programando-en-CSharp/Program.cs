using System;
using System.Collections.Generic;

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

        //Por si los Estatus deben ser accesibles para cualquiera
        public static class EstatusOperaciones
        {
            public const string _exitoso = "K120";
            public const string _clienteNoEncontrado = "P4";
            public const string _errorDelSistema = "K15";
        }
    }
}