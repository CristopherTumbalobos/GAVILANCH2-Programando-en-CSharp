using System;
using System.Collections.Generic;

namespace gavilanch2_Programando_en_CSharp
{
    //ENUM: Para evitar los números mágicos (con significado implícito)
    enum EstatusOperacion
    {
        Exitoso = 1,
        ClienteNoEncontrado = 2,
        ErrorDeSistema = 5,
    }

    class Program
    {
        static void Main(string[] args)
        {
            int estatusOperacion = 5;

            //(int): Casteandolo a int
            if (estatusOperacion == (int)EstatusOperacion.Exitoso)
            {
                // ...
            }
            else if (estatusOperacion == (int)EstatusOperacion.ClienteNoEncontrado)
            {
                // ...
            }
            else if (estatusOperacion == (int)EstatusOperacion.ErrorDeSistema)
            {
                // ...
            }

            Console.Read();
        }

        private static void OtroMetodo()
        {
            int estatusOperacion = 5;

            if (estatusOperacion == (int)EstatusOperacion.Exitoso)
            {
                // ...
            }
            else if (estatusOperacion == (int)EstatusOperacion.ClienteNoEncontrado)
            {
                // ...
            }
            else if (estatusOperacion == (int)EstatusOperacion.ErrorDeSistema)
            {
                // ...
            }
        }

    }
}