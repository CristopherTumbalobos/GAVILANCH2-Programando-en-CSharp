using System;
using System.Collections.Generic;
using Operaciones;

namespace gavilanch2_Programando_en_CSharp
{
    class Program
    {
        //Factoria: Metodo que devuelve la implementación de un interfaz. Permite reducir responsabilidades al método main.

        static void Main(string[] args)
        {
            var enviadorMensajeDependencia = FactoriaEnviadorMensaje.Factoria("sms");
            var enviadorMensaje = new EnviadorMensaje(enviadorMensajeDependencia);
            enviadorMensaje.EnviarMensaje("un mensaje");

            Console.Read();
        }
    }

    public static class FactoriaEnviadorMensaje
    {
        public static IEnviadorMensaje Factoria(string parametro)
        {
            if (parametro == "sms")
            {
                return new EnviarMiniMensaje();
            }
            else if (parametro == "correo")
            {
                return new EnviarCorreo();
            }

            throw new ApplicationException();
        }
    }
    public class EnviadorMensaje
    {
        public EnviadorMensaje()
        {
            _enviadorMensaje = new EnviarCorreo();
        }

        public EnviadorMensaje(IEnviadorMensaje enviadorMensaje)
        {
            _enviadorMensaje = enviadorMensaje;
        }

        public IEnviadorMensaje ImplementacionEnviadorMensaje { get; set; }

        private IEnviadorMensaje _enviadorMensaje;

        public void EnviarMensaje(string mensaje)
        {
            ImplementacionEnviadorMensaje.EnviarMensaje(mensaje);
        }
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