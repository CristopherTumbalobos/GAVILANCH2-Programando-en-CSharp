using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var miniMensaje = new EnviarMiniMensaje();
            var enviarCorreo = new EnviarCorreo();
            Enviar(miniMensaje, "prueba");
            Enviar(enviarCorreo, "prueba2");

            Console.Read();
        }

        public static void Enviar(IEnviadorMensaje mensajero, string mensaje)
        {
            mensajero.EnviarMensaje(mensaje);
        }
    }

    //Interface: Podemos usarlas para polimorfismo
    interface IEnviadorMensaje
    {
        //Método dentro de la interfaz
        void EnviarMensaje(string mensaje);
    }

    class EnviarMiniMensaje : IEnviadorMensaje
    {
        //Implementando el método de la interfaz
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando minimensaje");
        }
        public string CualquierMetodo()
        {
            return "Lo que sea";
        }
    }

    class EnviarCorreo : IEnviadorMensaje
    {
        //Implementando el método de la interfaz

        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando correo");
        }
    }
}