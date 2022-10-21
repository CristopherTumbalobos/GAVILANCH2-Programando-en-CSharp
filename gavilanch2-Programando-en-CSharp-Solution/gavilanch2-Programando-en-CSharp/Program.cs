using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inyeccion de dependencia: Sirve para desacoplar nuestras clases y ahorrar codigo. Nos dá flexibilidad a la hora de escoger las dependencia de nuestra clase

            //INYECCION DE DEPENDENCIA POR CONSTRUCTOR

            var enviadorSMS = new EnviarMiniMensaje();
            var enviadorMensaje = new EnviadorMensaje(enviadorSMS);//(enviadorSMS): Dependencia
            enviadorMensaje.EnviarMensaje("un mensaje");

            //INYECCION DE DEPENDENCIA MEDIANTE PROPIEDAD

            //var enviadorSMS = new EnviarMiniMensaje();
            //var enviadorMensaje = new EnviadorMensaje();
            //enviadorMensaje.ImplementacionEnviadorMensaje = enviadorSMS;
            //enviadorMensaje.EnviarMensaje("un mensaje");

            Console.Read();
        }
    }

    public class EnviadorMensaje
    {
        //INYECCION DE DEPENDENCIA POR CONSTRUCTOR

        public EnviadorMensaje(IEnviadorMensaje enviadorMensaje)
        {
            _enviadorMensaje = enviadorMensaje;
        }

        private IEnviadorMensaje _enviadorMensaje;

        public void EnviarMensaje(string mensaje)
        {
            _enviadorMensaje.EnviarMensaje(mensaje);
        }

        //INYECCION DE DEPENDENCIA MEDIANTE PROPIEDAD

        //public IEnviadorMensaje ImplementacionEnviadorMensaje { get; set; }

        //private IEnviadorMensaje _enviadorMensaje;

        //public void EnviarMensaje(string mensaje)
        //{
        //    ImplementacionEnviadorMensaje.EnviarMensaje(mensaje);
        //}
    }

    public interface IEnviadorMensaje
    {
        void EnviarMensaje(string mensaje);
    }
    class EnviarMiniMensaje : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando minimensaje");
        }
    }
    class EnviarCorreo : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando correo");
        }
    }
}