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

            //Este codigo ejectura la acción según el estatus de la operación (COMENTARIO INNECESARIO o REDUNDANTE)
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

            Suma(4, 5);

            Console.Read();
        }

        /// <summary>
        /// Metodo que sirve para sumar
        /// </summary>
        /// <param name="a">Sumando 1</param>
        /// <param name="b">Sumando 2</param>
        /// <returns>Retorna la suma de a y b</returns>
        private static int Suma(int a, int b)
        {
            return a + b;
        }
    }
}